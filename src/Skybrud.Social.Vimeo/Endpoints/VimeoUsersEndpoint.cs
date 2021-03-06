﻿using Skybrud.Social.Vimeo.Endpoints.Raw;
using Skybrud.Social.Vimeo.Options.Users;
using Skybrud.Social.Vimeo.Responses.Users;

namespace Skybrud.Social.Vimeo.Endpoints {

    /// <summary>
    /// Class representing the implementation of the <strong>Users</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.vimeo.com/api/endpoints/users</cref>
    /// </see>
    public class VimeoUsersEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Vimeo service.
        /// </summary>
        public VimeoService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public VimeoUsersRawEndpoint Raw => Service.Client.Users;

        #endregion

        #region Constructors

        internal VimeoUsersEndpoint(VimeoService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>An instance of <see cref="VimeoGetUserResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.vimeo.com/api/endpoints/users#/{user_id}</cref>
        /// </see>
        public VimeoGetUserResponse GetInfo(long userId) {
            return VimeoGetUserResponse.ParseResponse(Raw.GetInfo(userId));
        }

        /// <summary>
        /// Gets information about the user with the specified <paramref name="username"/>.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>An instance of <see cref="VimeoGetUserResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.vimeo.com/api/endpoints/users#/{user_id}</cref>
        /// </see>
        public VimeoGetUserResponse GetInfo(string username) {
            return VimeoGetUserResponse.ParseResponse(Raw.GetInfo(username));
        }

        /// <summary>
        /// Gets a list of channels of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the parent user.</param>
        /// <returns>An instance of <see cref="VimeoGetUserChannelsResponse"/> representing the response.</returns>
        public VimeoGetUserChannelsResponse GetChannels(long userId) {
            return VimeoGetUserChannelsResponse.ParseResponse(Raw.GetChannels(userId));
        }

        /// <summary>
        /// Gets a list of channels of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the parent user.</param>
        /// <param name="page">The page to be returned.</param>
        /// <param name="perPage">The maximum amount of pages to be returned per page.</param>
        /// <returns>An instance of <see cref="VimeoGetUserChannelsResponse"/> representing the response.</returns>
        public VimeoGetUserChannelsResponse GetChannels(long userId, int page, int perPage) {
            return VimeoGetUserChannelsResponse.ParseResponse(Raw.GetChannels(userId, page, perPage));
        }

        /// <summary>
        /// Gets a list of channels of the user with the specified <paramref name="username"/>.
        /// </summary>
        /// <param name="username">The username of the parent user.</param>
        /// <returns>An instance of <see cref="VimeoGetUserChannelsResponse"/> representing the response.</returns>
        public VimeoGetUserChannelsResponse GetChannels(string username) {
            return VimeoGetUserChannelsResponse.ParseResponse(Raw.GetChannels(username));
        }

        /// <summary>
        /// Gets a list of channels of the user with the specified <paramref name="username"/>.
        /// </summary>
        /// <param name="username">The username of the parent user.</param>
        /// <param name="page">The page to be returned.</param>
        /// <param name="perPage">The maximum amount of pages to be returned per page.</param>
        /// <returns>An instance of <see cref="VimeoGetUserChannelsResponse"/> representing the response.</returns>
        public VimeoGetUserChannelsResponse GetChannels(string username, int page, int perPage) {
            return VimeoGetUserChannelsResponse.ParseResponse(Raw.GetChannels(username, page, perPage));
        }

        /// <summary>
        /// Gets a list of user channels matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for request to the API.</param>
        /// <returns>An instance of <see cref="VimeoGetUserChannelsResponse"/> representing the response.</returns>
        public VimeoGetUserChannelsResponse GetChannels(VimeoGetUserChannelsOptions options) {
            return VimeoGetUserChannelsResponse.ParseResponse(Raw.GetChannels(options));
        }

        #endregion

    }

}