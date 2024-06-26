﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest511
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest511Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("027353c0-0fb6-47b2-9e88-f262d0af18a3")]
    public partial class MyTest511Repository : RepoGenBaseFolder
    {
        static MyTest511Repository instance = new MyTest511Repository();
        MyTest511RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest511Repository element repository.
        /// </summary>
        [RepositoryFolder("027353c0-0fb6-47b2-9e88-f262d0af18a3")]
        public static MyTest511Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest511Repository() 
            : base("MyTest511Repository", "/", null, 0, false, "027353c0-0fb6-47b2-9e88-f262d0af18a3", ".\\RepositoryImages\\MyTest511Repository027353c0.rximgres")
        {
            _rxmainframe = new MyTest511RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("027353c0-0fb6-47b2-9e88-f262d0af18a3")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("a7c4bfca-1e1d-41f3-aeed-45868875e511")]
        public virtual MyTest511RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest511RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("a7c4bfca-1e1d-41f3-aeed-45868875e511")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "a7c4bfca-1e1d-41f3-aeed-45868875e511", "")
            {
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/button[@controlname='btnSubmitUserName']", "", 30000, null, "ceb475be-ca29-4bc7-9233-b5a1ead8d7aa");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a7c4bfca-1e1d-41f3-aeed-45868875e511")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a7c4bfca-1e1d-41f3-aeed-45868875e511")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("ceb475be-ca29-4bc7-9233-b5a1ead8d7aa")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("ceb475be-ca29-4bc7-9233-b5a1ead8d7aa")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
