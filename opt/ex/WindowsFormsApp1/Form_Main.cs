using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Reflection.Emit;



namespace WindowsFormsApp1
{
  public partial class Form_Main : Form
  {
    Form_Start FSTART;

    wcom _wcom;


    public Form_Main()
    {
      InitializeComponent();


      LocalLoad();
    }


    public void LocalLoad()
    {
      _wcom = new wcom();
      _wcom.open();
    }




//추가
    void DGV_Unit_ReSet()
    {
      dgv_Module.MultiSelect = false;
      dgv_Module.Rows.Clear();


      dgv_Module.ClearSelection();
    }



    Int32 ReadProtocol(Int32 fd, byte[] b, Int32 sz)
    {
      Int32 e = 0;
      string dbg;

      int i = 0;
      dbg = "====================================\r\n";
      for (i = 0; i < sz; i++)
      {
        if (i > 0 && (i % 8) == 0) dbg += "  ";
        if (i > 0 && (i % 16) == 0) dbg += "\r\n";

        dbg += string.Format("{0:X2} ", b[i]);
      }
      dbg += "\r\n====================================\r\n";
      System.Diagnostics.Debug.Write(dbg);

      return e;
    }





    private void fileFToolStripMenuItem_Click(object sender, EventArgs e)
    {


    }


    private void TSM_Main_Print_Click(object sender, EventArgs e)
    {

    }

    private void editEToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void TSM_Main_Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TSM_Main_SelectAll_Click(object sender, EventArgs e)
    {
      Grid_SelectAll();
    }

    private void TSM_Main_ModuleSave_Click(object sender, EventArgs e)
    {
      saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      saveFileDialog1.CheckFileExists = false;
      saveFileDialog1.FileName = "ModuleStatus_" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";
      DialogResult dr = saveFileDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        string path = saveFileDialog1.FileName;
        FileInfo fi = new FileInfo(path);
        if (fi.Exists)
        {
          fi.Delete();
        }


        LogEx.CSVWrite(path, "모듈 상태");
        string data = "";
        for (int j = 0; j < dgv_Module.ColumnCount; j++)
        {
          data += dgv_Module.Columns[j].HeaderText + ",";
        }
        LogEx.CSVWrite(path, data);
        data = "";

        for (int i = 0; i < dgv_Module.RowCount; i++)
        {
          for (int j = 0; j < dgv_Module.ColumnCount; j++)
          {
            data += dgv_Module.Rows[i].Cells[j].Value + ",";
          }
          LogEx.CSVWrite(path, data);
        }
        LogEx.CSVWrite(path, "");
        LogEx.CSVWrite(path, "채널 상태");
        for (int j = 0; j < dgv_Channel.ColumnCount; j++)
        {
          data += dgv_Channel.Columns[j].HeaderText + ",";
        }
        LogEx.CSVWrite(path, data);

        data = "";
        for (int i = 0; i < dgv_Channel.RowCount; i++)
        {
          for (int j = 0; j < dgv_Channel.ColumnCount; j++)
          {
            data += dgv_Channel.Rows[i].Cells[j].Value + ",";
          }
          LogEx.CSVWrite(path, data);
        }
        LogEx.mLog("Module Status Save");
      }
    }
    Bitmap printmemoryImage;




    private void TSM_Main_ScheduleEditor_Click(object sender, EventArgs e)
    {

    }

    private void TSM_Main_Copy_Click(object sender, EventArgs e)
    {
      copy_Clipborad();
    }

 
    //copy_Clipborad() 코드
    public void copy_Clipborad()
    {
      if (tabControl1.SelectedIndex == 5)
      {
        if (dgv_Channel.SelectedRows.Count > 0)
        {
          int ncount = dgv_Channel.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_Channel.GetClipboardContent());
        }
      }
      else if (tabControl1.SelectedIndex == 0)
      {
        if (dgv_State.SelectedCells.Count > 0)
        {
          int ncount = dgv_State.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_State.GetClipboardContent());
        }
      }
      else if (tabControl1.SelectedIndex == 1)
      {
        if (dgv_Voltage.SelectedCells.Count > 0)
        {
          int ncount = dgv_Voltage.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_Voltage.GetClipboardContent());
        }
      }
      else if (tabControl1.SelectedIndex == 2)
      {
        if (dgv_Current.SelectedCells.Count > 0)
        {
          int ncount = dgv_Current.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_Current.GetClipboardContent());
        }
      }
      else if (tabControl1.SelectedIndex == 3)
      {
        if (dgv_Capacity.SelectedCells.Count > 0)
        {
          int ncount = dgv_Capacity.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_Capacity.GetClipboardContent());
        }
      }
      else if (tabControl1.SelectedIndex == 4)
      {
        if (dgv_TestName.SelectedCells.Count > 0)
        {
          int ncount = dgv_TestName.SelectedRows.Count;
          Clipboard.SetDataObject(dgv_TestName.GetClipboardContent());
        }
      }


    }

    //Grid_SelectAll() 코드
    void Grid_SelectAll()
    {
      if (tabControl1.SelectedIndex == 0)
      {
        dgv_State.SelectAll();
      }
      else if (tabControl1.SelectedIndex == 1)
      {
        dgv_Voltage.SelectAll();
      }
      else if (tabControl1.SelectedIndex == 2)
      {
        dgv_Current.SelectAll();
      }
      else if (tabControl1.SelectedIndex == 3)
      {
        dgv_Capacity.SelectAll();
      }
      else if (tabControl1.SelectedIndex == 4)
      {
        dgv_TestName.SelectAll();
      }
      else if (tabControl1.SelectedIndex == 5)
      {

        dgv_Channel.SelectAll();
      }
    }

    private void TSM_Main_TrayNo_Click(object sender, EventArgs e)
    {

    }

    private void tsb_Stop_Click(object sender, EventArgs e)
    {
      LogEx.mLog("Stop Icon Clicked");
      //Stop_instant();
    }

    private void tsb_Start_Click(object sender, EventArgs e)
    {
      LogEx.mLog("Start Icon Clicked");
      FSTART = new Form_Start();
      FSTART.ShowDialog();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form_Main_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    /*
    private void panel1_Resize(object sender, EventArgs e)
    {
    panel1.Width = this.ClientSize.Width; 
    } 
    */





  }












  //***************세부 파일****************
  public class LogEx
  {
    //YJLEE
    public static object lckLog = new object();

    public static void mLog(string data)
    {
      //bool isfile = false;
      string filepath = ".\\LOG\\mLOG\\LOG_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
      string strDate;

      strDate = "[" + DateTime.Now.ToString("HH:mm:ss:fffff") + "] ";//YJLEE

      DirectoryInfo dir = new DirectoryInfo(".\\LOG\\mLOG");

      if (dir.Exists == false)
      {
        dir.Create();
      }

      //if (File.Exists(filepath))
      //{
      //    isfile = true;
      //}

      try
      {
        StreamWriter SWrite = new StreamWriter(filepath, true, Encoding.Unicode);

        SWrite.WriteLine(strDate + data);

        SWrite.Close();
      }
      catch
      {
      }
    }


    public static void CSVWrite(string fileName, string data)
    {
      //bool isfile = false;
      if (!String.IsNullOrEmpty(fileName))
      {
        string strDate;
        string[] temp;
        string path = "";
        //strDate = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] ";
        temp = fileName.Split('\\');
        for (int i = 0; i < temp.Length - 2; i++)
        {
          path += temp[i];
        }
        DirectoryInfo dir = new DirectoryInfo(path);

        if (dir.Exists == false)
        {
          dir.Create();
        }

        //if (File.Exists(filepath))
        //{
        //    isfile = true;
        //}

        StreamWriter SWrite = new StreamWriter(fileName, true, Encoding.UTF8);

        SWrite.WriteLine(data);

        SWrite.Close();
      }
    }


  }





}
