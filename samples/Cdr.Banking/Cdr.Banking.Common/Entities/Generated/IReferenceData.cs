/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using Beef.RefData;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Provides for the required <b>ReferenceData</b> capabilities. 
    /// </summary>
    public partial interface IReferenceData : IReferenceDataProvider
    {
        #region Collections

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.OpenStatusCollection"/>.
        /// </summary>
        RefDataNamespace.OpenStatusCollection OpenStatus { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.ProductCategoryCollection"/>.
        /// </summary>
        RefDataNamespace.ProductCategoryCollection ProductCategory { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.AccountUTypeCollection"/>.
        /// </summary>
        RefDataNamespace.AccountUTypeCollection AccountUType { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.MaturityInstructionsCollection"/>.
        /// </summary>
        RefDataNamespace.MaturityInstructionsCollection MaturityInstructions { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.TransactionTypeCollection"/>.
        /// </summary>
        RefDataNamespace.TransactionTypeCollection TransactionType { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.TransactionStatusCollection"/>.
        /// </summary>
        RefDataNamespace.TransactionStatusCollection TransactionStatus { get; }

        #endregion
    }
}

#pragma warning restore IDE0005
#nullable restore