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
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public class WarningCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }
        public int? TIMELINE_ID { get; set; }

        //Constructor
        public WarningCRUD() { } //End public WarningCRUD()
        public void Create(WarningdetailVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Warning oModel = new Warning();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Process CRUD
                    db.Warnings.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(WarningdetailVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    poViewModel.SHORT_DESC = poViewModel.FULL_DESC;
                    Warning oModel = db.Warnings.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    WarninghiddenVM oModelhidden = new WarninghiddenVM();
                    oModelhidden.InjectFrom(oModel);
                    poViewModel.InjectFrom(oModelhidden);
                    
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;
                    this.TIMELINE_ID = oModel.TIMELINE_ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
        public void Delete(int? id)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Warning oModel = db.Warnings.Find(id);
                    db.Warnings.Remove(oModel);
                    if (oModel.TIMELINE_ID != null)
                    {
                        Timeline oModeltimeline = db.Timelines.Find(oModel.TIMELINE_ID);
                        if (oModeltimeline != null) { db.Timelines.Remove(oModeltimeline); } //End if (oModeltimeline != null)
                    } //End if (oModel.TIMELINE_ID != null)

                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete
    } //End public class WarningCRUD
} //End namespace APPBASE.Models

