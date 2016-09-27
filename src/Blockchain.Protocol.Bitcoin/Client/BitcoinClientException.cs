﻿// <copyright file="BitcoinClientException.cs" company="SoftChains">
//  Copyright 2016 Dan Gershony
//  Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
namespace Blockchain.Protocol.Bitcoin.Client
{
    #region Using Directives

    using System;
    using System.Net;

    using Blockchain.Protocol.Bitcoin.Extension;

    #endregion

    /// <summary>
    /// The bit net client exception.
    /// </summary>
    public class BitcoinClientException : ApplicationException
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinClientException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="ex">
        /// The ex.
        /// </param>
        public BitcoinClientException(string message, Exception ex)
            : base(message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinClientException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public BitcoinClientException(string message)
            : base(message)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public override string Message
        {
            get { return "StatusCode='{0}' Error={1}".StringFormat(this.StatusCode, base.Message); }
        }

        /// <summary>
        /// Gets or sets the client error.
        /// </summary>
        public string RawMessage { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return "StatusCode = {0} Error = {1} {2}".StringFormat(this.StatusCode, this.RawMessage, base.ToString());
        }

        /// <summary>
        /// Is this a transaction not found error.
        /// </summary>
        /// <returns>
        /// True if transaction not found.
        /// </returns>
        public bool IsTransactinNotFoundError()
        {
            return this.ErrorCode == -5 && this.ErrorMessage == "No information available about transaction";
        }

        #endregion
    }
}