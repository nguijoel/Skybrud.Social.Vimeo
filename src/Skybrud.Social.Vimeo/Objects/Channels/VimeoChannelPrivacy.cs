﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Vimeo.Objects.Channels {
    
    /// <summary>
    /// Class with privacy information about a Vimeo channel.
    /// </summary>
    public class VimeoChannelPrivacy : VimeoObject {

        #region Properties

        /// <summary>
        /// Gets the privacy status of the channel.
        /// </summary>
        public VimeoChannelPrivacyStatus View { get; private set; }

        #endregion

        #region Constructors

        private VimeoChannelPrivacy(JObject obj) : base(obj) {
            View = obj.GetEnum<VimeoChannelPrivacyStatus>("view");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="VimeoChannelPrivacy"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="VimeoChannelPrivacy"/>.</returns>
        public static VimeoChannelPrivacy Parse(JObject obj) {
            return obj == null ? null : new VimeoChannelPrivacy(obj);
        }

        #endregion

    }

}