﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [PrimaryKey(nameof(UserId), nameof(ArtistId))]
    public class BlockedArtist : BaseEntity
    {
        public Guid UserId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; } = null!;
        public Guid ArtistId { get; set; }
        [JsonIgnore]
        public virtual Artist Artist { get; set; } = null!;
        public DateTime blocked_date { get; set; }
    }
}
