//// -----------------------------------------------------------------------
//// <copyright file="App_Start.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------


using BK1.Models;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BK1.App_Start), "PreStart")]

namespace BK1 {
    public static class App_Start {
        public static void PreStart() {
          
        }
    }
}