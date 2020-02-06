using System;

namespace Library.API.Models
{
    /// <summary>
    ///     An author with Id, FirstName and LastName fields
    /// </summary>
    public class Author
    {
        /// <summary>
        ///     Id of the author
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     First name of the author
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Last name of the author
        /// </summary>
        public string LastName { get; set; }
    }
}