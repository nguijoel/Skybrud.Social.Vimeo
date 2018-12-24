using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Vimeo.Models.Videos
{
    /// <summary>
    /// Class describing a file of a Vimeo video.
    /// </summary>
    public class VimeoVideoFile : VimeoObject
    {
        #region Properties

        /// <summary>
        /// Gets the quality.
        /// </summary>
        /// <value>The quality.</value>
        public string Quality { get; }

        /// <summary>
        /// Gets the type of the MIME.
        /// </summary>
        /// <value>The type of the MIME.</value>
        public string MimeType { get; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; }

        /// <summary>
        /// Gets the secure URL.
        /// </summary>
        /// <value>The secure URL.</value>
        public string SecureUrl { get; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; }

        /// <summary>
        /// Gets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get; }

        #endregion Properties

        #region Constructors

        private VimeoVideoFile(JObject obj) : base(obj)
        {
            Quality = obj.GetString("quality");
            MimeType = obj.GetString("type");
            Url = obj.GetString("link");
            SecureUrl = obj.GetString("link_secure");
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
        }

        #endregion Constructors

        #region Static methods

        /// <summary>
        /// Parses the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>VimeoVideoFile.</returns>
        public static VimeoVideoFile Parse(JObject obj)
         => obj == null 
            ? null
            : new VimeoVideoFile(obj);

        #endregion Static methods
    }
}