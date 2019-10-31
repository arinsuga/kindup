﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    [Table("EDU01STUDENT")]
    public class Student : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public string NAME { get; set; }
        public string NICKNAME { get; set; }
        public string NIS { get; set; }
        public string NISN { get; set; }
        public string PINREG { get; set; }
        public string REGNO { get; set; }
        public DateTime? REG_DT { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? YEAR_ID { get; set; }
        public Byte? SEMESTER_ID { get; set; }
        public Byte? CLASSTYPE_ID { get; set; }
        public Byte? SEX_ID { get; set; }
        public string POB { get; set; }
        public DateTime? DOB { get; set; }
        public Byte? RELIGION_ID { get; set; }
        public Byte? NATIONALITY_ID { get; set; }
        public string LANGUAGE { get; set; }
        public string ETHNIC { get; set; }
        public Byte? CHILD_SEQ { get; set; }
        public Byte? CHILD_QTY { get; set; }
        public Byte? ADDR_COUNTRY_ID { get; set; }
        public string ADDR_CITY { get; set; }
        public string ADDR_KEC { get; set; }
        public string ADDR_KEL { get; set; }
        public string ADDR_ZIP { get; set; }
        public string ADDR_STREET1 { get; set; }
        public string ADDR_STREET2 { get; set; }
        public string HOME_PHONE { get; set; }
        public string CELL_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string PREV_SCHOOL_NAME { get; set; }
        public string PREV_SCHOOL_ADDR { get; set; }
        public Byte? BLOOD_TYPE_ID { get; set; }
        public Byte? WEIGHT_KG { get; set; }
        public Byte? HEIGHT_CM { get; set; }
        public string MEDICAL_STORY1 { get; set; }
        public string MEDICAL_STORY2 { get; set; }
        public string FTHR_NAME { get; set; }
        public string FTHR_POB { get; set; }
        public DateTime? FTHR_DOB { get; set; }
        public Byte? FTHR_RELIGION_ID { get; set; }
        public Byte? FTHR_NATIONALITY_ID { get; set; }
        public Byte? FTHR_EDU_ID { get; set; }
        public Byte? FTHR_JOB_ID { get; set; }
        public string FTHR_JOB_COMPANY { get; set; }
        public string FTHR_JOB_ADDR1 { get; set; }
        public string FTHR_JOB_ADDR2 { get; set; }
        public int? FTHR_INCOME { get; set; }
        public string FTHR_EMAIL { get; set; }
        public string FTHR_HOMEPHONE { get; set; }
        public string FTHR_CELLPHONE { get; set; }
        public Byte? FTHR_ADDR_COUNTRY_ID { get; set; }
        public string FTHR_ADDR_CITY { get; set; }
        public string FTHR_ADDR_KEC { get; set; }
        public string FTHR_ADDR_KEL { get; set; }
        public string FTHR_ADDR_ZIP { get; set; }
        public string FTHR_ADDR_STREET1 { get; set; }
        public string FTHR_ADDR_STREET2 { get; set; }
        public string MTHR_NAME { get; set; }
        public string MTHR_POB { get; set; }
        public DateTime? MTHR_DOB { get; set; }
        public Byte? MTHR_RELIGION_ID { get; set; }
        public Byte? MTHR_NATIONALITY_ID { get; set; }
        public Byte? MTHR_EDU_ID { get; set; }
        public Byte? MTHR_JOB_ID { get; set; }
        public string MTHR_JOB_COMPANY { get; set; }
        public string MTHR_JOB_ADDR1 { get; set; }
        public string MTHR_JOB_ADDR2 { get; set; }
        public int? MTHR_INCOME { get; set; }
        public string MTHR_EMAIL { get; set; }
        public string MTHR_HOMEPHONE { get; set; }
        public string MTHR_CELLPHONE { get; set; }
        public Byte? MTHR_ADDR_COUNTRY_ID { get; set; }
        public string MTHR_ADDR_CITY { get; set; }
        public string MTHR_ADDR_KEC { get; set; }
        public string MTHR_ADDR_KEL { get; set; }
        public string MTHR_ADDR_ZIP { get; set; }
        public string MTHR_ADDR_STREET1 { get; set; }
        public string MTHR_ADDR_STREET2 { get; set; }
        public string STUDENT_IMG { get; set; }
        public string FTHR_IMG { get; set; }
        public string MTHR_IMG { get; set; }
        public int? CLASSROOM_ID { get; set; }
        public int? STUDENTSTS_ID { get; set; }
        public string NEXT_SCHOOL_NAME { get; set; }
        public DateTime? NEXT_SCHOOL_DT { get; set; }
    } //End public class Student : CRUD
} //End namespace APPBASE.Models
