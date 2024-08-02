using System;
using System.Resources;
using PocketBook.Models.Localization;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    /// <summary>
    /// The BusinessBase class serves as the base class for all business entities in the wso.esl.BusinessEntities namespace.
    /// Since it inheirts from ValidationBase, it provides validation behavior to its child classes. Additionally, it implements
    /// default behavior for concurrency checks.
    /// </summary>
    public abstract class BusinessBase : ValidationBase
    {
        /// <summary>
        /// The ID of the BusinessBase instance in the database.
        /// </summary>
        public abstract int Id { get; set; }

        /// <summary>
        /// Gets or sets a concurrency id that is used to keep track of changes made to the underlying data recor in the database.
        /// </summary>
        /// <value>The concurrency id.</value>
        public byte[] ConcurrencyId { get; set; }

        /// <summary>
        /// The ResuurceManager sued by the validation framework.
        /// </summary>
        public static ResourceManager ResourceManager { get; set; }

        /// <summary>
        /// Gets the localized validation message based on the message key.
        /// </summary>
        /// <param name="key">The translation key of the validation message.</param>
        protected override string GetValidationMessage(string key)
        {
            string tempValue;
            if (ResourceManager != null)
            {
                tempValue = ResourceManager.GetString(key);
            }
            else
            {
                tempValue = string.Empty;
            }
            if (string.IsNullOrEmpty(tempValue))
            {
                tempValue = General.ResourceManager.GetString(key);
            }
            return tempValue;
        }
    }
}