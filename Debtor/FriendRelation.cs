﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtor
{
    class FriendRelation
    {
        public string id { get; set; }

        [JsonProperty(PropertyName = "host_person_live_id")]
        public string host_person_live_id { get; set; }

        [JsonProperty(PropertyName = "friend_person_live_id")]
        public string friend_person_live_id { get; set; }

        public FriendRelation(string host_person_live_id, string friend_person_live_id)
        {
            this.host_person_live_id = host_person_live_id;
            this.friend_person_live_id = friend_person_live_id;
        }
    }
}
