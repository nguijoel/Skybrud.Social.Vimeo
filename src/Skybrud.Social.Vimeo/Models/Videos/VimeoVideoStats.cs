﻿using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Vimeo.Models.Tags;

namespace Skybrud.Social.Vimeo.Models.Videos {
    
    /// <summary>
    /// Class with statistics about a Vimeo video.
    /// </summary>
    public class VimeoVideoStats : VimeoObject {

        #region Properties

        public long Plays { get; }

        #endregion

        #region Constructors

        private VimeoVideoStats(JObject obj) : base(obj) {
            Plays = obj.GetInt64("plays");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="VimeoVideoStats"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="VimeoVideoStats"/>.</returns>
        public static VimeoVideoStats Parse(JObject obj) {
            return obj == null ? null : new VimeoVideoStats(obj);
        }

        #endregion

    }

}