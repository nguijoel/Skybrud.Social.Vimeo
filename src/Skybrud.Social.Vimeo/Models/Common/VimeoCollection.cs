﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Vimeo.Models.Common {

    /// <summary>
    /// Class representing a generic collection returned by the Vimeo API.
    /// </summary>
    public class VimeoCollection : VimeoObject {

        #region Properties

        /// <summary>
        /// Gets the total amount of items in the collection.
        /// </summary>
        public int Total { get; }

        /// <summary>
        /// Gets the current page.
        /// </summary>
        public int Page { get; }

        /// <summary>
        /// Gets the maximum amount of items per page.
        /// </summary>
        public int PerPage { get; }

        /// <summary>
        /// Gets pagination URLs about the collection.
        /// </summary>
        public VimeoPaging Paging { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new collection based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> representing the collection.</param>
        protected VimeoCollection(JObject obj) : base(obj) {
            Total = obj.GetInt32("total");
            Page = obj.GetInt32("page");
            PerPage = obj.GetInt32("per_page");
            Paging = obj.GetObject("paging", VimeoPaging.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="VimeoCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="VimeoCollection"/>.</returns>
        public static VimeoCollection Parse(JObject obj) {
            return obj == null ? null : new VimeoCollection(obj);
        }

        #endregion

    }

}