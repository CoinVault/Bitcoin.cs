﻿// <copyright file="TransactionInfo.cs" company="SoftChains">
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

    using System.Collections.Generic;

    using Newtonsoft.Json;

    #endregion

    /// <summary>
    /// The list transactions info.
    /// </summary>
    public class TransactionInfo
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the block hash.
        /// </summary>
        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// Gets or sets the block index.
        /// </summary>
        [JsonProperty("blockindex")]
        public int BlockIndex { get; set; }

        /// <summary>
        /// Gets or sets the block time.
        /// </summary>
        [JsonProperty("blocktime")]
        public long BlockTime { get; set; }

        /// <summary>
        /// Gets or sets the confirmations.
        /// </summary>
        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public IEnumerable<TransactionInfoDetails> Details { get; set; }

        /// <summary>
        /// Gets or sets the  time.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Gets or sets the time received.
        /// </summary>
        [JsonProperty("timereceived")]
        public long TimeReceived { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [JsonProperty("txid")]
        public string Txid { get; set; }

        #endregion
    }
}