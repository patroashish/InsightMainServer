﻿/* Copyright 2013 Wisconsin Wireless and NetworkinG Systems (WiNGS) Lab, University of Wisconsin Madison.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingServer
{
    /// <summary>
    /// Server configuration constants. Only need to modify this file for setting up the server.
    /// </summary>
    class Constants
    {
        // Database related constants. 
        public const string MYSQL_SERVER = "xxxx"; // Update the server hostname based on the server setup.
        public const string MYSQL_USERNAME = "dummy"; // Update mysql username based on the server setup.
        public const string MYSQL_PASSWORD = "dummy"; // Update mysql password based on the server setup.
        public const string MYSQL_DBNAME = "insight_stats";
        public const string MYSQL_TABLE = "pingsrecorded";
    }
}
