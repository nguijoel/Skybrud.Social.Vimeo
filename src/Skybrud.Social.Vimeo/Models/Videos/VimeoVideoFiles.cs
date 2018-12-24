using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Vimeo.Models.Videos {
    
    /// <summary>
    /// Class describing the files of a Vimeo video.
    /// </summary>
    public class VimeoVideoFiles : VimeoObject {

        #region Properties

        public VimeoVideoFile[] Files  { get; }

        #endregion

        #region Constructors

        private VimeoVideoFiles(JObject obj) : base(obj) {
            Files = obj.GetArrayItems("sizes", VimeoVideoFile.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="VimeoVideoFiles"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="VimeoVideoFiles"/>.</returns>
        public static VimeoVideoFiles Parse(JObject obj) => obj == null ? null : new VimeoVideoFiles(obj);
    
        #endregion
    }
}