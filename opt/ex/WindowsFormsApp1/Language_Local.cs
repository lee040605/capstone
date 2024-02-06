using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Language_Local
    {
        //DefaultSet
        public static string[] Main_Control = { "파일", "상태 저장", "인쇄", "종료"," 편집", "복사", "전체 선택", "Tray(Pack) 번호 입력", "제어 명령", "작업 시작"
                                              , "작업 멈춤", "즉시 멈춤 시행", "현재 Step 완료 후", "현재 Cycle 반복 완료 후", "작업 계속", "다음 Step", "작업 완료", "즉시 완료 시행", "현재 Step 완료 후","현재 Cycle 반복 완료 후"
                                              , "설정","시스템 설정","사용자 설정", "관리자 계정 설정","관리자 계정 초기화", "안전조건 설정", "전류/전압 제한조건 설정","병렬 모드 설정","도구","ScheduleEditor"
                                              , "Analyzer","보기","작업 결과 보기","스케줄 확인","작업 로그 보기","System 로그 화면","도구 모음","상태 표시줄","언어","언어 변경"
                                              , "도움말","Monitor 정보","시      작", "작업 멈춤","즉시 멈춤 시행","현재 Step 완료 후","현재 Cycle 반복 완료 후", "작업 계속","Next Step","작업 완료"
                                              , "즉시 완료 시행", "현재 Step 완료 후", "현재 Cycle 반복 완료 후", "통신 연결","작업 시작","작업 멈춤","즉시 멈춤 시행", "현재 Step 완료 후", "현재 Cycle 반복 완료 후", "작업 계속"
                                              , "Next Step", "채널 초기화","작업 완료","즉시 완료 시행","현재 Step 완료 후", "현재 Cycle 반복 완료 후", "결과 Data 확인", "그래프 그리기", "진행 스케줄 확인","작업 로그 보기"
                                              , "결과 Data 폴더 열기", "복사", "전체 선택", "작업 Tray 번호", "Module 정보", "Channel 정보", "전체 보기", "선택 Module", "선택 Channel", "준비 상태 채널"
                                              , "평균 전압", "최대 전압", "최소 전압", "상태", "전압", "전류", "용량", "시험명", "상세 보기"};
        public static string[] Main_Message = { "Monitor 프로그램을 종료 하시겠습니까?", "병렬모드로 설정되어 있습니다.", "Master 채널에서 실행 하세요", "로그 파일이 없습니다.", "최근 진행된 시험이 없습니다.", "Analyzer 경로를 확인하세요.", "결과 폴더가 없습니다.", "상세 보기에서 채널을 선택 하세요.", "스케줄 파일이 없습니다.", "Schedule Editor 경로를 확인 하세요.", "권한이 없습니다.", "초기화 하시겠습니까?", "언어 변경 하시겠습니까?", "언어 변경 실패했습니다." };
        public static string[] Main_GridModule = { "모듈", "연결 상태", "연결 시간", "전체 채널 수", "대기 채널 수", "작업 채널 수", "접속 횟수", "IP", "Spec" };
        public static string[] Main_GridChannel = { "채널", "상태", "전압", "전류", "용량", "Step 시간", "총 시간", "코드", "온도", "Cycle", "Step", "시험명", "스케줄명", "WattHour", "Power", "이름", "스케줄" };
        public static string[] Admin_Control = { "관리자 계정 설정", "관리자 계정을 추가/삭제/편집 합니다. 하나라도 입력되지 않은 항목은 저장되지 않습니다.", "ID", "비밀번호", "등급", "계정 추가", "계정 삭제", "적  용", "닫  기" };
        public static string[] Admin_Message = { "삭제 하시겠습니까?", "저장 하시겠습니까?", "입력되지 않은 항목이 있습니다.", "동일한 ID가 존재 합니다." };
        public static string[] AdminCheck_Control = { "관리자 확인", "Login", "ID", "Password", "OK", "Cancel" };
        public static string[] AdminCheck_Message = { "Password 불일치.", "존재하지 않는 ID 입니다." };
        public static string[] DriveSelector_Control = { "드라이브 선택", "드라이브", "기본 경로", "OK", "Cancel" };
        public static string[] DriveSelector_Message = { "해당 경로를 만들수 없습니다. 변경 후 다시 시도해주세요", "경로가 비어있습니다."};
        public static string[] EQNO_Control = { "Tray 정보 입력", "Tray 번호를 입력 하십시오.", "Tray Name :", "Tray 번호 :", "OK", "Cancel"};
        public static string[] EQNO_Message = { };
        public static string[] MonitorInfo_Control = { "모니터 정보"};
        public static string[] MonitorInfo_Message = { };
        public static string[] Parallel_Control = { "병렬 모드 설정", "채널", "Master/Slave", "병렬 설정", "적용", "닫기"};
        public static string[] Parallel_Message = { "적용 하시겠습니까?", "작업중인 채널은 변경 할 수 없습니다.", "채널 연결을 확인해주세요"};
        public static string[] SafetyTemp_Control = { };
        public static string[] SafetyTemp_Message = { };
        public static string[] SafetyConditions_Control = { "안전조건 설정", "각 Ch의 값이 설정값 이상 초과시 해당 모듈의 모든 작업을 중단합니다.", "Cell 과전압 방지 조건"
                                                            , "mV 이상 시 전체 작업 멈춤", "Cell 과열 방지 조건", "℃ 이상 시 전체 작업 멈춤", "적용", "닫기" };
        public static string[] SafetyConditions_Message = { "저장 되었습니다.", "저장 실패 했습니다."};
        public static string[] SaveDataSetting_Control = { "저장 Data 설정", "No", "Data 목록", "Use", "적용", "닫기"};
        public static string[] SaveDataSetting_Message = { };
        public static string[] ScheduleView_Control = { "스케줄 확인", "상세 내용", "No.", "Type", "전압", "전류", "온도", "스케줄 정보", "이    름", "작성자"
                                                      , "설    명", "수정일", "End조건", "Voltage", "Current", "Capacity", "Time", "Watt", "WattHour", "Delta V"
                                                      , "Delta I", "SOC", "CV Time", "기타", "안전 조건", "Voltage", "Current", "Capacity", "Watt", "WattHour"
                                                      , "온도", "저장 조건", "전압 변화", "시간 변화", "전류 변화", "온도 변화", "EXCEL Export", "닫    기" };
        public static string[] ScheduleView_Message = { "스케줄 파일이 없습니다." };
        public static string[] Start_Control = { "시험 시작 화면", "스케줄 목록", "선택 작성자", "선택 스케줄", "작성자 목록", "작성자", "설명", "스케줄 목록", "스케줄 명", "작성 일자"
                                                , "스케줄 상세", "Step No.", "Type", "Mode", "Voltage", "Current", "종료 조건", "Name", "Value", "Next Step"
                                                , "안전 조건", "Name", "Value", "기록 조건", "Name", "Value", "시험 시작 설정", "시 험 명", "결과 저장 경로", "새로고침"
                                                , "스케줄 수정", "시험 시작", "Cancel", "......" };
        public static string[] Start_Message = { "취소 하시겠습니까?", "시험명을 입력해주세요.", "작성자를 선택해주세요.", "스케줄을 선택해주세요.", " (으)로 시작 하시겠습니까?"
                                                ,"설정된 경로의 드라이브가 없습니다. 기본 결과 저장 경로 설정을 실행합니다.", "동일한 시험명의 결과가 존재합니다."
                                                ,"Schedule Editor 경로를 확인해주세요." };
        public static string[] System_Control = { "경로 설정", "스케줄 경로", "결과 경로", "장비 로그 경로", "Schedule Editor 경로", "Analyzer 경로", "모듈 설정", "모듈 수", "세부 설정", "이름", "IP", "Port", "채널 수", "저    장", "닫    기" };
        public static string[] System_Message = { "저장되었습니다.", "Port는 최대 65535 까지 입니다.", "채널은 최대 8개 입니다.", "채널은 최소 1개 입니다." };
        public static string[] UserSettings_Control = { "사용자 설정", "데이터 단위 설정", "항목", "단위", "소수점자릿수", "전압", "전류", "용량", "Watt", "WattHour"
                                                        , "시간", "데이터 표시 그리드 설정", "가나다AaBbCcYyZz", "폰트 선택", "Grid 표시 Column수", "데이터 갱신 주기 설정", "모듈 상태 갱신 주기", "채널 상태 갱신 주기", "상세보기 표기 데이터 설정", "No"
                                                        , "Data 목록", "표기명", "Width", "색상 설정", "상태", "미리보기", "Font", "Back", "Blink", "Stpe Type", "저    장", "닫    기" };
        public static string[] UserSettings_Message = { "Column 수는 최대 16입니다.", "저장되었습니다." };
        public static string[] VoltageCurrentLimit_Control = { "전압/전류 제한조건 설정", "전압 제한조건 사용", "전압", "시간", "동작설정1", "동작설정2", "전류 제한조건 사용", "전류", "적  용", "닫  기" };
        public static string[] VoltageCurrentLimit_Message = { "저장되었습니다." };
        public static string[] Alarm_Control = { "채널 초기화", "알람 초기화 후 재개", "Close" };
        public static string[] Alarm_Message = { };
        public static string[] ACFault_Message = { "인버터부 FET 문제 발생", "오류1 발생", "오류2 발생", "입력 과전압 발생", "입력 저전압 발생", "오류3 발생", "오류4 발생", "오류5 발생", "초기 충전 실패", "인버터부 FET 문제 발생", "오류6 발생", "오류7 발생" };
        public static string[] DCFault_Message = { "1차측 정류단 과충전 발생", "1차측 정류단 저전압 발생", "2차측 정류단 과충전 발생", "2차측 정류단 저전압 발생", "충전중 출력단 접촉 불량", "방전중 출력단 접촉 불량", "Cell 과충전 발생", "Cell 저전압 발생", "Cell 과전류 발생", "Cell 저전류 발생", "절연부 FET 문제 발생", "DCDC부 FET 문제 발생"};
        public static string[] OPFault_Message = { "비상스위치 동작", "입력 퓨즈 소손", "출력 퓨즈 소손" ,"인버터부 스위칭소자 과열" , "절연부 스위칭소자 과열", "절연부 고주파변압기 과열", "DCDC부 스위칭소자 과열", "FAN 동작 이상" , "I/F 통신 이상", "병렬 CV 동작 이상", "병렬 모드 동작 이상", "병렬 채널 Fault 발생" };
        public static string[] STFault_Message = { "Cell 센싱 케이블 역결선", "전류 케이블 역결선", "시험전류 초과", "시험전압 초과", "시험전력 초과", "전류설정값 이상", "전압설정값 이상", "병렬 이웃채널 Warning 발생", "오류1 발생", "오류2 발생", "=오류3 발생", "오류4 발생" };
        public static string[] CompleteCode = { "전압 종료", "전류 종료", "용량 종료", "전력 종료", "SOC 종료", "Delta V 종료", "Delta I 종료", "시간 종료", "사용자 종료" };
        public static string[] SafetyCode = { "전압 상한", "전압 하한", "전류 상한", "전력량 상한" ,"용량 상한", "전력 상한", "온도 상한" };
        static int getColumnIndex(string columnName)
        {
            int ret = 0;

            switch (columnName)
            {
                case "Channel":
                    ret = 0;
                    break;
                case "State":
                    ret = 1;
                    break;
                case "StepTime":
                    ret = 2;
                    break;
                case "Voltage":
                    ret = 3;
                    break;
                case "Current":
                    ret = 4;
                    break;
                case "Capacity":
                    ret = 5;
                    break;
                case "TotalTime":
                    ret = 6;
                    break;
                case "Code":
                    ret = 7;
                    break;
                case "Temperature":
                    ret = 8;
                    break;
                case "Step":
                    ret = 9;
                    break;
                case "TestName":
                    ret = 10;
                    break;
                case "Schedule":
                    ret = 11;
                    break;
                case "WattHour":
                    ret = 12;
                    break;
                case "Power":
                    ret = 13;
                    break;
                case "Cycle":
                    ret = 14;
                    break;
            }

            return ret;
        }

        
        public static void setIndexFromName()
        {
            for (int i = 0; i < Language.LanguageData.Count; i++)
            {
                string name = Language.LanguageData[i].Name;
                switch (name)
                {
                    case "Main_Control":
                        //if(Language.LanguageData[i].Data.Count < Main_Control.Length)
                        //{ break; }
                        Main_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Main_Message":
                        if (Language.LanguageData[i].Data.Count < Main_Message.Length)
                        { break; }
                        Main_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Main_Grid_Module":
                        if (Language.LanguageData[i].Data.Count < Main_GridModule.Length)
                        { break; }
                        Main_GridModule = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Main_Grid_Channel":
                        if (Language.LanguageData[i].Data.Count < Main_GridChannel.Length)
                        { break; }
                        Main_GridChannel = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Admin_Control":
                        if (Language.LanguageData[i].Data.Count < Admin_Control.Length)
                        { break; }
                        Admin_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Admin_Message":
                        if (Language.LanguageData[i].Data.Count < Admin_Message.Length)
                        { break; }
                        Admin_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "AdminCheck_Control":
                        if (Language.LanguageData[i].Data.Count < AdminCheck_Control.Length)
                        { break; }
                        AdminCheck_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "AdminCheck_Message":
                        if (Language.LanguageData[i].Data.Count < AdminCheck_Message.Length)
                        { break; }
                        AdminCheck_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "DriveSelector_Control":
                        if (Language.LanguageData[i].Data.Count < DriveSelector_Control.Length)
                        { break; }
                        DriveSelector_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "DriveSelector_Message":
                        if (Language.LanguageData[i].Data.Count < DriveSelector_Message.Length)
                        { break; }
                        DriveSelector_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "EQNO_Control":
                        if (Language.LanguageData[i].Data.Count < EQNO_Control.Length)
                        { break; }
                        EQNO_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "EQNO_Message":
                        if (Language.LanguageData[i].Data.Count < EQNO_Message.Length)
                        { break; }
                        EQNO_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "MonitorInfo_Control":
                        if (Language.LanguageData[i].Data.Count < MonitorInfo_Control.Length)
                        { break; }
                        MonitorInfo_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "MonitorInfo_Message":
                        if (Language.LanguageData[i].Data.Count < MonitorInfo_Message.Length)
                        { break; }
                        MonitorInfo_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Parallel_Control":
                        if (Language.LanguageData[i].Data.Count < Parallel_Control.Length)
                        { break; }
                        Parallel_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Parallel_Message":
                        if (Language.LanguageData[i].Data.Count < Parallel_Message.Length)
                        { break; }
                        Parallel_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SafetyTemp_Control":
                        if (Language.LanguageData[i].Data.Count < SafetyTemp_Control.Length)
                        { break; }
                        SafetyTemp_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SafetyTemp_Message":
                        if (Language.LanguageData[i].Data.Count < SafetyTemp_Message.Length)
                        { break; }
                        SafetyTemp_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SafetyConditions_Control":
                        if (Language.LanguageData[i].Data.Count < SafetyConditions_Control.Length)
                        { break; }
                        SafetyConditions_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SafetyConditions_Message":
                        if (Language.LanguageData[i].Data.Count < SafetyConditions_Message.Length)
                        { break; }
                        SafetyConditions_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SaveDataSetting_Control":
                        if (Language.LanguageData[i].Data.Count < SaveDataSetting_Control.Length)
                        { break; }
                        SaveDataSetting_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SaveDataSetting_Message":
                        if (Language.LanguageData[i].Data.Count < SaveDataSetting_Message.Length)
                        { break; }
                        SaveDataSetting_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "ScheduleView_Control":
                        if (Language.LanguageData[i].Data.Count < ScheduleView_Control.Length)
                        { break; }
                        ScheduleView_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "ScheduleView_Message":
                        if (Language.LanguageData[i].Data.Count < ScheduleView_Message.Length)
                        { break; }
                        ScheduleView_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Start_Control":
                        if (Language.LanguageData[i].Data.Count < Start_Control.Length)
                        { break; }
                        Start_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Start_Message":
                        if (Language.LanguageData[i].Data.Count < Start_Message.Length)
                        { break; }
                        Start_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "System_Control":
                        if (Language.LanguageData[i].Data.Count < System_Control.Length)
                        { break; }
                        System_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "System_Message":
                        if (Language.LanguageData[i].Data.Count < System_Message.Length)
                        { break; }
                        System_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "UserSettings_Control":
                        if (Language.LanguageData[i].Data.Count < UserSettings_Control.Length)
                        { break; }
                        UserSettings_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "UserSettings_Message":
                        if (Language.LanguageData[i].Data.Count < UserSettings_Message.Length)
                        { break; }
                        UserSettings_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "VoltageCurrentLimit_Control":
                        if (Language.LanguageData[i].Data.Count < VoltageCurrentLimit_Control.Length)
                        { break; }
                        VoltageCurrentLimit_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "VoltageCurrentLimit_Message":
                        if (Language.LanguageData[i].Data.Count < VoltageCurrentLimit_Message.Length)
                        { break; }
                        VoltageCurrentLimit_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Alarm_Control":
                        if (Language.LanguageData[i].Data.Count < Alarm_Control.Length)
                        { break; }
                        Alarm_Control = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "Alarm_Message":
                        if (Language.LanguageData[i].Data.Count < Alarm_Message.Length)
                        { break; }
                        Alarm_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "StringValueSet":
                        if (Language.LanguageData[i].Data.Count < 18)
                        { break; }
                        StringValueSet.Start = Language.LanguageData[i].Data[0];
                        StringValueSet.Stop = Language.LanguageData[i].Data[1];
                        StringValueSet.Complete = Language.LanguageData[i].Data[2];
                        StringValueSet.Disconnected = Language.LanguageData[i].Data[3];
                        StringValueSet.Connected = Language.LanguageData[i].Data[4];
                        StringValueSet.Rest = Language.LanguageData[i].Data[5];
                        StringValueSet.Ready = Language.LanguageData[i].Data[6];
                        StringValueSet.Prepare = Language.LanguageData[i].Data[7];
                        StringValueSet.Pause = Language.LanguageData[i].Data[8];
                        StringValueSet.ScheduleSave = Language.LanguageData[i].Data[9];
                        StringValueSet.Charge = Language.LanguageData[i].Data[10];
                        StringValueSet.Discharge = Language.LanguageData[i].Data[11];
                        StringValueSet.OCV = Language.LanguageData[i].Data[12];
                        StringValueSet.Pattern = Language.LanguageData[i].Data[13];
                        StringValueSet.UserStop = Language.LanguageData[i].Data[14];
                        StringValueSet.UserStop_Wait = Language.LanguageData[i].Data[15];
                        StringValueSet.Error = Language.LanguageData[i].Data[16];
                        StringValueSet.Normal = Language.LanguageData[i].Data[17];
                        break;
                    case "ACFault_Message":
                        if (Language.LanguageData[i].Data.Count < ACFault_Message.Length)
                        { break; }
                        ACFault_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "DCFault_Message":
                        if (Language.LanguageData[i].Data.Count < DCFault_Message.Length)
                        { break; }
                        DCFault_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "OPFault_Message":
                        if (Language.LanguageData[i].Data.Count < OPFault_Message.Length)
                        { break; }
                        OPFault_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "STFault_Message":
                        if (Language.LanguageData[i].Data.Count < STFault_Message.Length)
                        { break; }
                        STFault_Message = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "CompleteCode":
                        if (Language.LanguageData[i].Data.Count < CompleteCode.Length)
                        { break; }
                        CompleteCode = Language.LanguageData[i].Data.ToArray();
                        break;
                    case "SafetyCode":
                        if (Language.LanguageData[i].Data.Count < SafetyCode.Length)
                        { break; }
                        SafetyCode = Language.LanguageData[i].Data.ToArray();
                        break;
                }
            }
            Language.LanguageData = new List<Language.cLanguage>();
        }
        //public static void setIndexFromName(string name)
        //{
        //    for (int i = 0; i < Language.LanguageData.Count; i++)
        //    {
        //        if (name == Language.LanguageData[i].Name)
        //        {
        //            switch (name)
        //            {
        //                case "Main_Control":
        //                    Main_Control = i;
        //                    break;
        //                case "Main_Message":
        //                    Main_Message = i;
        //                    break;
        //                case "Main_GridModule":
        //                    Main_GridModule = i;
        //                    break;
        //                case "Main_GridChannel":
        //                    Main_GridChannel = i;
        //                    break;
        //                case "Admin_Control":
        //                    Admin_Control = i;
        //                    break;
        //                case "Admin_Message":
        //                    Admin_Message = i;
        //                    break;
        //                case "AdminCheck_Control":
        //                    AdminCheck_Control = i;
        //                    break;
        //                case "AdminCheck_Message":
        //                    AdminCheck_Message = i;
        //                    break;
        //                case "DriveSelector_Control":
        //                    DriveSelector_Control = i;
        //                    break;
        //                case "DriveSelector_Message":
        //                    DriveSelector_Message = i;
        //                    break;
        //                case "EQNO_Control":
        //                    EQNO_Control = i;
        //                    break;
        //                case "EQNO_Message":
        //                    EQNO_Message = i;
        //                    break;
        //                case "MonitorInfo_Control":
        //                    MonitorInfo_Control = i;
        //                    break;
        //                case "MonitorInfo_Message":
        //                    MonitorInfo_Message = i;
        //                    break;
        //                case "Parallel_Control":
        //                    Parallel_Control = i;
        //                    break;
        //                case "Parallel_Message":
        //                    Parallel_Message = i;
        //                    break;
        //                case "SafetyTemp_Control":
        //                    SafetyTemp_Control = i;
        //                    break;
        //                case "SafetyTemp_Message":
        //                    SafetyTemp_Message = i;
        //                    break;
        //                case "SafetyConditions_Control":
        //                    SafetyConditions_Control = i;
        //                    break;
        //                case "SafetyConditions_Message":
        //                    SafetyConditions_Message = i;
        //                    break;
        //                case "SaveDataSetting_Control":
        //                    SaveDataSetting_Control = i;
        //                    break;
        //                case "SaveDataSetting_Message":
        //                    SaveDataSetting_Message = i;
        //                    break;
        //                case "ScheduleView_Control":
        //                    ScheduleView_Control = i;
        //                    break;
        //                case "ScheduleView_Message":
        //                    ScheduleView_Message = i;
        //                    break;
        //                case "Start_Control":
        //                    Start_Control = i;
        //                    break;
        //                case "Start_Message":
        //                    Start_Message = i;
        //                    break;
        //                case "System_Control":
        //                    System_Control = i;
        //                    break;
        //                case "System_Message":
        //                    System_Message = i;
        //                    break;
        //                case "UserSettings_Control":
        //                    UserSettings_Control = i;
        //                    break;
        //                case "UserSettings_Message":
        //                    UserSettings_Message = i;
        //                    break;
        //                case "VoltageCurrentLimit_Control":
        //                    VoltageCurrentLimit_Control = i;
        //                    break;
        //                case "VoltageCurrentLimit_Message":
        //                    VoltageCurrentLimit_Message = i;
        //                    break;
        //            }
        //            break;
        //        }
        //    }
        //}
    }
}
