﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognitivo.API.Models
{   
    /// <summary>
    /// Item.
    /// </summary>
    [DataContract]
    public class Item
    {
        public Item() { isPrivate = false; attachments = new List<Attachments>(); tags = new string[50]; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? localId { get; set; }

        /// <summary>
        /// Gets or sets the cloud identifier.
        /// </summary>
        /// <value>The cloud identifier.</value>
        [DataMember]
        public int? cloudId { get; set; }

        /// <summary>
        /// Gets or sets the global item cloud identifier.
        /// </summary>
        /// <value>The global item cloud identifier.</value>
        [DataMember]
        public int? globalItem { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        /// <value>The short description.</value>
        public string shortDescription { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the long description.
        /// </summary>
        /// <value>The long description.</value>
        public string longDescription { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>The sku.</value>
        public string sku { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>The sku.</value>
        public string code { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the bar code.
        /// </summary>
        /// <value>The bar code.</value>
        public string barCode { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public Enums.ItemTypes type { get; set; }


        [DataMember]
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The status.</value>
        public Enums.Action? action { get; set; }
        

        [DataMember]
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public int? categoryCloudId { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>The vat.</value>
        public int? vatCloudId { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currencyCode { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public decimal? price { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public decimal? cost { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Core.Models.Item"/> weigh with scale.
        /// </summary>
        /// <value><c>true</c> if weigh with scale; otherwise, <c>false</c>.</value>
        public bool weighWithScale { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public decimal? weight { get; set; }

        [DataMember]
        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        /// <value>The volume.</value>
        public decimal? volume { get; set; }

        /// <summary>
        /// Gets or sets the is private.
        /// </summary>
        /// <value>The is private.</value>
        [DataMember]
        public bool isPrivate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Cognitivo.API.Models.Item"/> is active.
        /// </summary>
        /// <value><c>true</c> if is active; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool isActive { get; set; }

        [DataMember]
        public bool isStockable { get; set; }


        [DataMember]
        public DateTime updatedAt { get; set; }
        [DataMember]
        public DateTime createdAt { get; set; }
        [DataMember]
        public DateTime? deletedAt { get; set; }
        [DataMember]
        public List<Attachments> attachments { get; set; }
        [DataMember]
        public string[] tags { get; set; }

    }
    public class Attachments
    {
        [DataMember]
        public byte[] attachment { get; set; }
        public long? cloudId { get; set; }
    }

    
}
