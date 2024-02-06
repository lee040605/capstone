using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  class Store
  {
    string title;
  }
  class Print
  {
    string title;

  }

  class File
  {
    Store store;
    Print print;
  }
  class Edit
  {

  }

  class Menu
  {
    File file;
    Menu menu;
  }

  class TopWindow
  {

  }

  class MainWindow
  {

  }


  public static class StringValueSet
  {
    public static string CCCV = "CC/CV";
    public static string CC = "CC";
    public static string CV = "CV";
    public static string CR = "CR";
    public static string CP = "CP";

    public static string Start = "작업중";
    public static string Stop = "준비";
    public static string Complete = "완료";
    public static string Disconnected = "연결끊김";
    public static string Connected = "연결됨";
    public static string Rest = "Rest";
    public static string Ready = "작업준비";
    public static string Prepare = "작업대기";
    public static string Pause = "작업멈춤";
    public static string ScheduleSave = "스케줄 저장";
    public static string Charge = "충전";
    public static string Discharge = "방전";
    public static string OCV = "OCV";
    public static string Pattern = "Pattern";
    public static string UserStop = "중지";
    public static string UserStop_Wait = "중지";
    public static string Error = "오류";
    public static string Normal = "정상";
  }

  public class Language_file
  {
    Menu menu;
    TopWindow topwindow;
    MainWindow mainwindow;
  }

}
