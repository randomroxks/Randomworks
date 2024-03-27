// -----------------------------------------------------------------------
//  <copyright file="ZtPermissions.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ZtFramework
{
    public enum ZtControlPermissionsEnum
    {
        //None -- normal
        None,
        Hidden,
        ShowNotEdit
    }

    public sealed class ZtPermissions
    {
        public ZtControlPermissionsEnum ControlPermissions { get; set; }
    }
}