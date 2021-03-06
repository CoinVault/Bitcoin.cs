﻿// <copyright file="TransactionOutputInfo.cs" company="SoftChains">
//  Copyright 2016 Dan Gershony
//  Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
namespace Blockchain.Protocol.Bitcoin.Client.Types
{
    #region Using Directives

    using Newtonsoft.Json;

    #endregion

    /// <summary>
    /// The list transactions info.
    /// </summary>
    public class TransactionOutputInfo
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty("value")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the best block.
        /// </summary>
        [JsonProperty("bestblock")]
        public string BestBlock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether coin base.
        /// </summary>
        [JsonProperty("coinbase")]
        public bool CoinBase { get; set; }

        /// <summary>
        /// Gets or sets the confirmations.
        /// </summary>
        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        /// <summary>
        /// Gets or sets the script pub key.
        /// </summary>
        [JsonProperty("scriptPubKey")]
        public ScriptPubKey ScriptPubKey { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [JsonProperty("version")]
        public long Version { get; set; }

        #endregion
    }
}