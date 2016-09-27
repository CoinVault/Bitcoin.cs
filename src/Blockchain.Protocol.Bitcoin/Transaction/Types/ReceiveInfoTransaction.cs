﻿// <copyright file="ReceiveInfoTransaction.cs" company="SoftChains">
//  Copyright 2016 Dan Gershony
//  Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
namespace Blockchain.Protocol.Bitcoin.Transaction.Types
{
    /// <summary>
    /// The transaction input.
    /// </summary>
    public class ReceiveInfoTransaction
    {
        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Gets or sets the v out.
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// Gets or sets the v out.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        public string ScriptPubKeyHex { get; set; }
    }
}
