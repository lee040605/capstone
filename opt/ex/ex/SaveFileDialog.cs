#region 어셈블리 System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Windows.Forms.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System.ComponentModel;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace System.Windows.Forms;

//
// 요약:
//     사용자에게 파일을 저장할 위치를 선택하라는 메시지를 표시합니다. 이 클래스는 상속될 수 없습니다.
[Designer("System.Windows.Forms.Design.SaveFileDialogDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[SRDescription("DescriptionSaveFileDialog")]
public sealed class SaveFileDialog : FileDialog
{
    //
    // 요약:
    //     존재하지 않는 파일을 지정할 때 파일을 새로 만들 것인지 사용자에게 묻는 메시지가 대화 상자에 표시되는지 여부를 나타내는 값을 가져오거나
    //     설정합니다.
    //
    // 반환 값:
    //     존재하지 않는 파일을 지정할 때 파일을 새로 만들 것인지 사용자에게 묻는 메시지가 대화 상자에 표시되면 true이고 사용자에게 묻는 메시지가
    //     표시되지 않고 대화 상자에서 자동으로 새 파일을 만들면 false입니다. 기본값은 false입니다.
    [SRCategory("CatBehavior")]
    [DefaultValue(false)]
    [SRDescription("SaveFileDialogCreatePrompt")]
    public bool CreatePrompt
    {
        get
        {
            return GetOption(8192);
        }
        set
        {
            IntSecurity.FileDialogCustomization.Demand();
            SetOption(8192, value);
        }
    }

    //
    // 요약:
    //     이미 존재하는 파일 이름을 지정할 때 Save As 대화 상자에 경고가 표시되는지 여부를 나타내는 값을 가져오거나 설정합니다.
    //
    // 반환 값:
    //     이미 존재하는 파일 이름을 지정할 때 대화 상자에 경고가 표시되면 true이고 사용자에게 묻는 메시지를 표시하지 않고 자동으로 기존 파일을
    //     덮어쓰면 false입니다. 기본값은 true입니다.
    [SRCategory("CatBehavior")]
    [DefaultValue(true)]
    [SRDescription("SaveFileDialogOverWritePrompt")]
    public bool OverwritePrompt
    {
        get
        {
            return GetOption(2);
        }
        set
        {
            IntSecurity.FileDialogCustomization.Demand();
            SetOption(2, value);
        }
    }

    //
    // 요약:
    //     읽기/쓰기 권한을 사용하여 선택한 파일을 엽니다.
    //
    // 반환 값:
    //     사용자가 선택한 읽기/쓰기 파일입니다.
    public Stream OpenFile()
    {
        IntSecurity.FileDialogSaveFile.Demand();
        string text = base.FileNamesInternal[0];
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentNullException("FileName");
        }

        Stream stream = null;
        new FileIOPermission(FileIOPermissionAccess.AllAccess, IntSecurity.UnsafeGetFullPath(text)).Assert();
        try
        {
            return new FileStream(text, FileMode.Create, FileAccess.ReadWrite);
        }
        finally
        {
            CodeAccessPermission.RevertAssert();
        }
    }

    private bool PromptFileCreate(string fileName)
    {
        return MessageBoxWithFocusRestore(SR.GetString("FileDialogCreatePrompt", fileName), base.DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
    }

    private bool PromptFileOverwrite(string fileName)
    {
        return MessageBoxWithFocusRestore(SR.GetString("FileDialogOverwritePrompt", fileName), base.DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
    }

    internal override bool PromptUserIfAppropriate(string fileName)
    {
        if (!base.PromptUserIfAppropriate(fileName))
        {
            return false;
        }

        if (((uint)options & 2u) != 0 && FileDialog.FileExists(fileName) && !base.UseVistaDialogInternal && !PromptFileOverwrite(fileName))
        {
            return false;
        }

        if (((uint)options & 0x2000u) != 0 && !FileDialog.FileExists(fileName) && !PromptFileCreate(fileName))
        {
            return false;
        }

        return true;
    }

    //
    // 요약:
    //     모든 대화 상자 옵션을 기본값으로 다시 설정합니다.
    public override void Reset()
    {
        base.Reset();
        SetOption(2, value: true);
    }

    internal override void EnsureFileDialogPermission()
    {
        IntSecurity.FileDialogSaveFile.Demand();
    }

    internal override bool RunFileDialog(NativeMethods.OPENFILENAME_I ofn)
    {
        IntSecurity.FileDialogSaveFile.Demand();
        bool saveFileName = UnsafeNativeMethods.GetSaveFileName(ofn);
        if (!saveFileName)
        {
            int num = SafeNativeMethods.CommDlgExtendedError();
            if (num == 12290)
            {
                throw new InvalidOperationException(SR.GetString("FileDialogInvalidFileName", base.FileName));
            }
        }

        return saveFileName;
    }

    internal override string[] ProcessVistaFiles(FileDialogNative.IFileDialog dialog)
    {
        FileDialogNative.IFileSaveDialog fileSaveDialog = (FileDialogNative.IFileSaveDialog)dialog;
        dialog.GetResult(out var ppsi);
        return new string[1] { FileDialog.GetFilePathFromShellItem(ppsi) };
    }

    internal override FileDialogNative.IFileDialog CreateVistaDialog()
    {
        return (FileDialogNative.NativeFileSaveDialog)new FileDialogNative.FileSaveDialogRCW();
    }

    //
    // 요약:
    //     이 클래스의 새 인스턴스를 초기화합니다.
    public SaveFileDialog()
    {
    }
}
#if false // 디컴파일 로그
캐시의 '13'개 항목
------------------
확인: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
단일 어셈블리를 찾았습니다. 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\mscorlib.dll'
------------------
확인: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
단일 어셈블리를 찾았습니다. 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Drawing.dll'
------------------
확인: 'System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
'System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' 이름으로 찾을 수 없습니다.
------------------
확인: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
단일 어셈블리를 찾았습니다. 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Xml.dll'
------------------
확인: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
단일 어셈블리를 찾았습니다. 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.dll'
------------------
확인: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
단일 어셈블리를 찾았습니다. 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Core.dll'
------------------
확인: 'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
'System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' 이름으로 찾을 수 없습니다.
------------------
확인: 'Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
'Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' 이름으로 찾을 수 없습니다.
------------------
확인: 'System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
단일 어셈블리를 찾았습니다. 'System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
로드 위치: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Deployment.dll'
------------------
확인: 'System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
'System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' 이름으로 찾을 수 없습니다.
#endif
