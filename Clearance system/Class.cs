﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

namespace ClearanceSystem
{
    public class Class
    {
        String[] List = new String[10];
        void fun1()
        {
             
        }

        public string sendEmail(string email, string from)
        {
            MailMessage msg = new MailMessage("kiotServer@gmail.com", email);
            string rdm =""+ new System.Random().Next(1000000, 7000000);
            msg.Subject = "Email from KIOT " + from;
            msg.Body = "Your agreement code :::> " + rdm;
            msg.IsBodyHtml = true;
            new Message().SendEmail(msg);
            return rdm;
        }
       public DataItem Detail(DataSet ds)
        {
            //  Fname,Lname,Departement,AcademicR,photo ,Email
            DataItem di = new DataItem();
        
                di.str1 = (string)ds.Tables[0].Rows[0][0] + " " + (string)ds.Tables[0].Rows[0][1];
                di.str2 = (string)ds.Tables[0].Rows[0][2];
                di.str3 = (string)ds.Tables[0].Rows[0][3];
                di.str4 = "~/" + (string)ds.Tables[0].Rows[0][4];
                di.str5 = (string)ds.Tables[0].Rows[0][5];
           
              
            return di;
        }

    }
}