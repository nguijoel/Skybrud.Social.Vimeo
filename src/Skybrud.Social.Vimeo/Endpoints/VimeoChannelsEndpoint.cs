﻿using Skybrud.Social.Vimeo.Endpoints.Raw;
using Skybrud.Social.Vimeo.Options.Channels;
using Skybrud.Social.Vimeo.Responses.Channels;

namespace Skybrud.Social.Vimeo.Endpoints {

    /// <summary>
    /// Class representing the implementation of the <strong>Channels</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.vimeo.com/api/endpoints/channels</cref>
    /// </see>
    public class VimeoChannelsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Vimeo service.
        /// </summary>
        public VimeoService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public VimeoChannelsRawEndpoint Raw => Service.Client.Channels;

        #endregion

        #region Constructors

        internal VimeoChannelsEndpoint(VimeoService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the channel with the specified <paramref name="channelId"/>.
        /// </summary>
        /// <param name="channelId">The ID of the user.</param>
        /// <returns>An instance of <see cref="VimeoGetChannelResponse"/> representing the response.</returns>
        public VimeoGetChannelResponse GetInfo(long channelId) {
            return VimeoGetChannelResponse.ParseResponse(Raw.GetInfo(channelId));
        }
        
        /// <summary>
        /// Gets a list of videos of the channel with the specified <paramref name="channelId"/>.
        /// </summary>
        /// <param name="channelId">The ID of the cannel.</param>
        /// <returns>An instance of <see cref="VimeoGetChannelVideosResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.vimeo.com/api/endpoints/channels#/{channel_id}/videos</cref>
        /// </see>
        public VimeoGetChannelVideosResponse GetVideos(long channelId) {
            return VimeoGetChannelVideosResponse.ParseResponse(Raw.GetVideos(channelId));
        }

        /// <summary>
        /// Gets a list of videos of the channel with the specified <paramref name="channelId"/>.
        /// </summary>
        /// <param name="channelId">The ID of the cannel.</param>
        /// <param name="page">The page to be returned.</param>
        /// <param name="perPage">The maximum amount of pages to be returned per page.</param>
        /// <returns>An instance of <see cref="VimeoGetChannelVideosResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.vimeo.com/api/endpoints/channels#/{channel_id}/videos</cref>
        /// </see>
        public VimeoGetChannelVideosResponse GetVideos(long channelId, int page, int perPage) {
            return VimeoGetChannelVideosResponse.ParseResponse(Raw.GetVideos(channelId, page, perPage));
        }


        /// <summary>
        /// Gets a list of videos of the channel matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for request to the API.</param>
        /// <returns>An instance of <see cref="VimeoGetChannelVideosResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.vimeo.com/api/endpoints/channels#/{channel_id}/videos</cref>
        /// </see>
        public VimeoGetChannelVideosResponse GetVideos(VimeoGetChannelVideosOptions options) {
            return VimeoGetChannelVideosResponse.ParseResponse(Raw.GetVideos(options));
        }

        #endregion

    }

}