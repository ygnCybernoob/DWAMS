using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using DWAMS_DAL;


namespace DWAMS_BLL
{
   public class AttendanceController
    {
       AttendanceDataController datacontroller;
       AttendanceCollection collection;
       private int count;

       public AttendanceController()
       {
           datacontroller = new AttendanceDataController();
       }

       public void InsertOutdoorStaff(string staffid, DateTime attendanceDate)
       {
           datacontroller.InsertOutdoorStaff(staffid, attendanceDate);
       }

       public void DutyIn(string staffid, DateTime date, DateTime dutyin, double latedutyin, string remark, char late)
       {
           datacontroller.DutyIn(staffid, date, dutyin, latedutyin, remark, late);
       }

       public void DutyOut(string staffid, DateTime date, DateTime dutyout, double earlydutyout, string remark, char late)
       {
           datacontroller.DutyOut(staffid, date, dutyout, earlydutyout, remark , late);
       }

       public AttendanceCollection DailyAttendanceSelect()
       {
           collection = new AttendanceCollection();
           IDataReader reader = datacontroller.DailyAttendanceSelect();

           count = 0;

           while (reader.Read())
           {
               AttendanceInfo info = new AttendanceInfo();

               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["AttendanceDate"]);
               info.Staffcode = Convert.ToString(reader["StaffCode"]);
               info.Staffname = Convert.ToString(reader["StaffName"]);
               info.Dutyin = Convert.ToDateTime(reader["DutyIn"]);
               info.Latedutyin = Convert.ToInt32(reader["LateDutyIn"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }

               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);

               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public AttendanceCollection DailyAttendanceSelectbyDate(DateTime startdate, DateTime enddate)
       {
           collection = new AttendanceCollection();
           IDataReader reader = datacontroller.DailyAttendanceSelectbyDate(startdate, enddate);
           count = 0;
           while (reader.Read())
           {
               AttendanceInfo info = new AttendanceInfo();

               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["AttendanceDate"]);
               info.Staffcode = Convert.ToString(reader["StaffCode"]);
               info.Staffname = Convert.ToString(reader["StaffName"]);
               info.Dutyin = Convert.ToDateTime(reader["DutyIn"]);
               info.Latedutyin = Convert.ToInt32(reader["LateDutyIn"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }

               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);
               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public AttendanceCollection DailyAttendanceSelectbyStaffId(string staffid)
       {
           collection = new AttendanceCollection();
           IDataReader reader = datacontroller.DailyAttendanceSelectbyStaffId(staffid);
           count = 0;
           while (reader.Read())
           {
               AttendanceInfo info = new AttendanceInfo();

               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["AttendanceDate"]);
               info.Staffcode = Convert.ToString(reader["StaffCode"]);
               info.Staffname = Convert.ToString(reader["StaffName"]);
               info.Dutyin = Convert.ToDateTime(reader["DutyIn"]);
               info.Latedutyin = Convert.ToInt32(reader["LateDutyIn"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }

               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);
               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public AttendanceCollection DailyAttendanceSelectbyStaffIdDate(string staffid, DateTime startdate, DateTime enddate)
       {
           collection = new AttendanceCollection();
           IDataReader reader = datacontroller.DailyAttendanceSelectbyStaffIdDate(staffid, startdate, enddate);
           count = 0;
           while (reader.Read())
           {
               AttendanceInfo info = new AttendanceInfo();

               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["AttendanceDate"]);
               info.Staffcode = Convert.ToString(reader["StaffCode"]);
               info.Staffname = Convert.ToString(reader["StaffName"]);
               info.Dutyin = Convert.ToDateTime(reader["DutyIn"]);
               info.Latedutyin = Convert.ToInt32(reader["LateDutyIn"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }
               
               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);
               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public AttendanceStatus AttendanceCheckStatus(string staffid, DateTime date)
       {
           IDataReader reader = datacontroller.AttendanceCheckStatus(staffid, date);

           if (reader.Read())
           {
               if (string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   return AttendanceStatus.DutyOut;
               }
               else
               {
                   return AttendanceStatus.Full;
               }
           }
           else
           {
               return AttendanceStatus.DutyIn;
           }

       }

       public AttendanceCollection UnNormalAttendanceSelect()
       {
           IDataReader reader = datacontroller.UnNormalAttendanceSelect();
           collection = new AttendanceCollection();
           AttendanceInfo info;
           count = 0;
           while (reader.Read())
           {
               info = new AttendanceInfo();

               info.Attid = Convert.ToString(reader["AttId"]);
               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["Attendancedate"]);
               info.Staffcode = Convert.ToString(reader["Staffcode"]);
               info.Staffname = Convert.ToString(reader["Staffname"]);
               info.Dutyin = Convert.ToDateTime(reader["Dutyin"]);
               info.Latedutyin = Convert.ToInt32(reader["Latedutyin"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }

               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);
               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public AttendanceCollection UnNormalAttendanceSelectbyStaffId(string staffid)
       {
           IDataReader reader = datacontroller.UnNormalAttendanceSelectbyStaffid(staffid);
           collection = new AttendanceCollection();
           AttendanceInfo info;
           count = 0;
           while (reader.Read())
           {
               info = new AttendanceInfo();

               info.Attid = Convert.ToString(reader["AttId"]);
               info.Staffid = Convert.ToString(reader["StaffId"]);
               info.Attendancedate = Convert.ToDateTime(reader["Attendancedate"]);
               info.Staffcode = Convert.ToString(reader["Staffcode"]);
               info.Staffname = Convert.ToString(reader["Staffname"]);
               info.Dutyin = Convert.ToDateTime(reader["Dutyin"]);
               info.Latedutyin = Convert.ToInt32(reader["Latedutyin"]);

               info.Strdutyout = Convert.ToString(reader["DutyOut"]); //**
               info.Strearlydutyout = Convert.ToString(reader["EarlyDutyOut"]); //**

               if (!string.IsNullOrEmpty(Convert.ToString(reader["DutyOut"])))
               {
                   info.Dutyout = Convert.ToDateTime(reader["DutyOut"]); //**
                   info.Earlydutyout = Convert.ToInt32(reader["EarlyDutyOut"]); //**
               }
               else
               {
                   info.Strdutyout = "ရုံးတက္ေနစဲ"; //**
                   info.Strearlydutyout = "ရုံးတက္ေနစဲ"; //**
               }

               info.Remark1 = Convert.ToString(reader["Remark1"]);
               info.Remark2 = Convert.ToString(reader["Remark2"]);
               info.No = Convert.ToString(++count);
               collection.Add(info);
           }
           reader.Close();

           return collection;
       }

       public int UnNormalAttendanceCount()
       {
           int total = 0 ;
           IDataReader read = datacontroller.UnNormalAttendanceCount();
           if (read.Read())
           {
               total = Convert.ToInt32(read["Total"]);
           }   
           read.Close();
           return total;
       }

       //type >>
       //NL NE
       //NL
       //NE

       public void UnNormalAttendanceUpdate(string attendanceid, int latedutyin, int earlydutyout, string type)
       {
           datacontroller.UnNormalAttendanceUpdate(attendanceid, latedutyin, earlydutyout, type);
       }
    }

    public class AttendanceInfo
    {
        private string attid,
            staffid,
            staffcode,
            staffname,
            remark1,
            remark2;

        private int latedutyin,
            earlydutyout;

        private DateTime attendancedate,
            dutyin,
            dutyout;

        private string strdutyout,
            strearlydutyout,
            no;

        public string No
        {
            get { return no; }
            set { no = value; }
        }

        public string Strearlydutyout
        {
            get { return strearlydutyout; }
            set { strearlydutyout = value; }
        }

        public string Strdutyout
        {
            get { return strdutyout; }
            set { strdutyout = value; }
        }

        public string Remark2
        {
            get { return remark2; }
            set { remark2 = value; }
        }

        public string Remark1
        {
            get { return remark1; }
            set { remark1 = value; }
        }

        public string Staffname
        {
            get { return staffname; }
            set { staffname = value; }
        }

        public string Staffcode
        {
            get { return staffcode; }
            set { staffcode = value; }
        }

        public string Staffid
        {
            get { return staffid; }
            set { staffid = value; }
        }

        public string Attid
        {
            get { return attid; }
            set { attid = value; }
        }

        public DateTime Dutyout
        {
            get { return dutyout; }
            set { dutyout = value; }
        }

        public DateTime Dutyin
        {
            get { return dutyin; }
            set { dutyin = value; }
        }

        public DateTime Attendancedate
        {
            get { return attendancedate; }
            set { attendancedate = value; }
        }

        public int Earlydutyout
        {
            get { return earlydutyout; }
            set { earlydutyout = value; }
        }

        public int Latedutyin
        {
            get { return latedutyin; }
            set { latedutyin = value; }
        }
    }

    public class AttendanceCollection:Collection<AttendanceInfo>
    {
    }

    public enum AttendanceStatus
    {
        DutyIn, DutyOut, Full
    }
}
