using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class TextData
    {
        public string filename; //input
        public string[] rows; //process
        public int rowcount; //process
        public int pos; //input+process
        public bool eof; //process

        public void openData()
        {
            rows= File.ReadAllLines(filename, Encoding.UTF8);//Read file and return an array of text
            rowcount = rows.Length;
            pos = 0;
            eof = false;
        }
        public string getRow()
        {
            return rows[pos];
        }
        public string getColumn(int index)
        {
            return rows[pos].Split(',')[index];
        }
        public void moveNext()
        {
            pos++;
            if (pos >= rowcount)
            {
                pos = rowcount;
                eof = true;
            }
        }
        public void moveFirst()
        {
            pos = 0;
            eof = false;
        }
        public void moveLast()
        {
            pos = rowcount - 1;
            eof = false;
        }
        public void movePrevious()
        {
            pos--;
            eof = false;
            if (pos < 0) // ตรวจสอบไฟล์ว่าไม่ได้ติดลบ
            {
                pos = 0;
            }
        }

    }
}
