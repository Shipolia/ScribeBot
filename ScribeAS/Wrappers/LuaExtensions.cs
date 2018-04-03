﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe.Wrappers
{
    /// <summary>
    /// Class containing all functions that can and should be implemented from Lua environment itself.
    /// </summary>
    static class LuaExtensions
    {
        /// <summary>
        /// String containing code for 'wait(time)' function; Wait until 'time' milliseconds have passed.
        /// </summary>
        public static string Wait =
        @"
            function wait(time)
                local callTime = os.clock() + (time/1000)
                repeat until os.clock() > callTime
            end
        ";
    }
}
