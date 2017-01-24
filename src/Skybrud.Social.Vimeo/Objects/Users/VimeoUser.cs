﻿using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Vimeo.Objects.Pictures;

namespace Skybrud.Social.Vimeo.Objects.Users {
    
    /// <summary>
    /// Class describing a Vimeo user.
    /// </summary>
    public class VimeoUser : VimeoObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user. The ID isn't directly specified by the Vimeo API, but is derived from the <see cref="Uri"/> property.
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Gets the URI of the Vimeo user.
        /// </summary>
        public string Uri { get; private set; }

        /// <summary>
        /// Gets the name of the Vimeo user.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the link (URL for the profile page) of the Vimeo user.
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// Gets the location of the user. Use the <see cref="HasLocation"/> property to check whether a location has been specified.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// Gets whether the user has specified a location. If true, the location can be read from the <see cref="Location"/> property.
        /// </summary>
        public bool HasLocation {
            get { return !String.IsNullOrWhiteSpace(Location); }
        }

        /// <summary>
        /// Gets the bio of the user. Use the <see cref="HasBio"/> property to check whether a bio has been specified.
        /// </summary>
        public string Bio { get; private set; }

        /// <summary>
        /// Gets whether the user has specified a bio. If true, the bio can be read from the <see cref="Bio"/> property.
        /// </summary>
        public bool HasBio {
            get { return !String.IsNullOrWhiteSpace(Bio); }
        }

        /// <summary>
        /// Gets the timestamp for when the user was created.
        /// </summary>
        public EssentialsDateTime CreatedTime { get; private set; }

        /// <summary>
        /// Gets the account type of the user.
        /// </summary>
        public VimeoUserAccountType Account { get; private set; }

        /// <summary>
        /// Gets the default picture of the user. Use the <see cref="HasPicture"/> property to check whether the user
        /// has a default picture.
        /// </summary>
        public VimeoPicture Picture { get; private set; }

        /// <summary>
        /// Gets whether the user has default picture. If true, information about the picture can be read from the
        /// <see cref="Picture"/> property.
        /// </summary>
        public bool HasPicture {
            get { return !String.IsNullOrWhiteSpace(Bio); }
        }

        /// <summary>
        /// Gets an array of websites of the user.
        /// </summary>
        public VimeoUserWebsite[] Websites { get; private set; }

        /// <summary>
        /// Gets whether the user has specified any websites. If true, the websites can be read from the
        /// <see cref="Websites"/> property.
        /// </summary>
        public bool HasWebsites {
            get { return Websites.Length > 0; }
        }

        /// <summary>
        /// Gets the resource key of the channel.
        /// </summary>
        public string ResourceKey { get; private set; }

        #endregion

        #region Constructors

        private VimeoUser(JObject obj) : base(obj) {
            Uri = obj.GetString("uri");
            Id = Int64.Parse(Uri.Split('/').Last());
            Name = obj.GetString("name");
            Link = obj.GetString("link");
            Location = obj.GetString("location");
            Bio = obj.GetString("bio");
            CreatedTime = obj.GetString("created_time", EssentialsDateTime.Parse);
            Account = obj.GetEnum<VimeoUserAccountType>("account");
            Picture = obj.GetObject("pictures", VimeoPicture.Parse);
            Websites = obj.GetArrayItems("websites", VimeoUserWebsite.Parse);
            // "metadata"
            ResourceKey = obj.GetString("resource_key");
            // "preferences"
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="VimeoUser"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="VimeoUser"/>.</returns>
        public static VimeoUser Parse(JObject obj) {
            return obj == null ? null : new VimeoUser(obj);
        }

        #endregion

    }

}