// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace FunnelWeb.Web.Features.Admin {
    public partial class AdminController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AdminController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AdminController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteFeed() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteFeed);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeleteComment() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeleteComment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ToggleSpam() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ToggleSpam);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult DeletePingback() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.DeletePingback);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult TogglePingbackSpam() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.TogglePingbackSpam);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AdminController Actions { get { return FunnelWebMvc.Admin; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Admin";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Settings = "Settings";
            public readonly string Feeds = "Feeds";
            public readonly string DeleteFeed = "DeleteFeed";
            public readonly string Comments = "Comments";
            public readonly string DeleteComment = "DeleteComment";
            public readonly string DeleteAllSpam = "DeleteAllSpam";
            public readonly string ToggleSpam = "ToggleSpam";
            public readonly string Pingbacks = "Pingbacks";
            public readonly string DeletePingback = "DeletePingback";
            public readonly string TogglePingbackSpam = "TogglePingbackSpam";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string AdminController = "~/Features/Admin/AdminController.cs";
            static readonly _Scripts s_Scripts = new _Scripts();
            public _Scripts Scripts { get { return s_Scripts; } }
            public partial class _Scripts{
                public readonly string Admin = "~/Features/Admin/Scripts/Admin.js";
            }
            static readonly _Views s_Views = new _Views();
            public _Views Views { get { return s_Views; } }
            public partial class _Views{
                public readonly string Comments = "~/Features/Admin/Views/Comments.aspx";
                public readonly string CommentsModel = "~/Features/Admin/Views/CommentsModel.cs";
                public readonly string Feeds = "~/Features/Admin/Views/Feeds.aspx";
                public readonly string FeedsModel = "~/Features/Admin/Views/FeedsModel.cs";
                public readonly string Index = "~/Features/Admin/Views/Index.aspx";
                public readonly string IndexModel = "~/Features/Admin/Views/IndexModel.cs";
                public readonly string Pingbacks = "~/Features/Admin/Views/Pingbacks.aspx";
                public readonly string PingbacksModel = "~/Features/Admin/Views/PingbacksModel.cs";
                public readonly string Settings = "~/Features/Admin/Views/Settings.aspx";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_AdminController: FunnelWeb.Web.Features.Admin.AdminController {
        public T4MVC_AdminController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Settings() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Settings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Settings(FunnelWeb.Web.Application.Settings.Settings settings) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Settings);
            callInfo.RouteValueDictionary.Add("settings", settings);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Feeds() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Feeds);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Feeds(FunnelWeb.Web.Features.Admin.Views.FeedsModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Feeds);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteFeed(int feedId) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteFeed);
            callInfo.RouteValueDictionary.Add("feedId", feedId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Comments() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Comments);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteComment(int comment) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteComment);
            callInfo.RouteValueDictionary.Add("comment", comment);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeleteAllSpam() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeleteAllSpam);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ToggleSpam(int comment) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ToggleSpam);
            callInfo.RouteValueDictionary.Add("comment", comment);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Pingbacks() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Pingbacks);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult DeletePingback(int pingback) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.DeletePingback);
            callInfo.RouteValueDictionary.Add("pingback", pingback);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult TogglePingbackSpam(int pingback) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.TogglePingbackSpam);
            callInfo.RouteValueDictionary.Add("pingback", pingback);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591