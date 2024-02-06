using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slite.io;



namespace WindowsFormsApp1
{
    unsafe class wcom
    {
		public int TROW = 64;
		public int TCOL = 32;


		csSocket _socket;
        csXML    _xml;
        string[][] _title;
		int trow, tcol;


		public wcom()
        {
            _socket = new csSocket();
            _xml = new csXML();

            _socket._dlgtCallbackEx = new DlgtCallbackEx(OnSocketCallback);
            _xml._dlgtCallbackRead = new DlgtCallbackRead(OnXMLCallback);

            _title = new string[TROW][];
            for ( trow = 0; trow<TROW; trow++)
            {
                _title[trow] = new string[TCOL];
            }
            trow = tcol = 0;
        }
 

    public void open()
    {
      _socket.Open("127.0.0.1", "49243", "CLIENT");

        _xml.read("ko_KR.xml");
    }


        public void close()
        {

        }


        public int OnSocketCallback(Int32 fd, byte[] b, Int32 sz)
        {
            string dbg = string.Format("{0:X8}", sz);
            System.Diagnostics.Debug.Write("sz " + dbg);
            return 0;
        }


        public int OnXMLCallback(Int32 type, byte[] tag, byte[] dat)
        {
            string dbg;

            dbg = type + ":" + Encoding.UTF8.GetString(tag).Trim('\0') + ":" + Encoding.UTF8.GetString(dat).Trim('\0');

            switch((byte)type)
            {
              case 0x80: // Start Document
                break;

              case 0x01: // End of Document 1
                    tcol--;
                    trow++;
                break;

              case 0x81: // End of Document 2
                break;

              case 0x40: // Start Tag
                    _title[trow][tcol] = Encoding.UTF8.GetString(tag).Trim('\0');
                    tcol++;
				break;

              case 0x42: // End of Tag
                break;

              case 0: // Data    <TAG>Data</TAG>   --->  Data
					_title[trow][tcol] = Encoding.UTF8.GetString(tag).Trim('\0');
				break;

            }
            return 0;
        }

    }
}
