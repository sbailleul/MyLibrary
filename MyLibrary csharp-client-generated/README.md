# IO.Swagger - the C# library for the Library API

Through this API you can access authors and their books

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen
    For more information, please visit [https://www.linkedin.com/in/sacha-bailleul-a83762105/](https://www.linkedin.com/in/sacha-bailleul-a83762105/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author you want to get
            var version = version_example;  // string | 

            try
            {
                // Get an author by her/his id
                Author result = apiInstance.ApiVversionAuthorsAuthorIdGet(authorId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.ApiVversionAuthorsAuthorIdGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorsApi* | [**ApiVversionAuthorsAuthorIdGet**](docs/AuthorsApi.md#apivversionauthorsauthoridget) | **GET** /api/v{version}/authors/{authorId} | Get an author by her/his id
*AuthorsApi* | [**ApiVversionAuthorsAuthorIdPatch**](docs/AuthorsApi.md#apivversionauthorsauthoridpatch) | **PATCH** /api/v{version}/authors/{authorId} | Partially update and author
*AuthorsApi* | [**ApiVversionAuthorsAuthorIdPut**](docs/AuthorsApi.md#apivversionauthorsauthoridput) | **PUT** /api/v{version}/authors/{authorId} | 
*AuthorsApi* | [**ApiVversionAuthorsGet**](docs/AuthorsApi.md#apivversionauthorsget) | **GET** /api/v{version}/authors | 
*BooksApi* | [**ApiVversionAuthorsAuthorIdBooksGet**](docs/BooksApi.md#apivversionauthorsauthoridbooksget) | **GET** /api/v{version}/authors/{authorId}/books | Get the books for a specific author
*BooksApi* | [**CreateBook**](docs/BooksApi.md#createbook) | **POST** /api/v{version}/authors/{authorId}/books | Create a book for a specific author
*BooksApi* | [**GetBook**](docs/BooksApi.md#getbook) | **GET** /api/v{version}/authors/{authorId}/books/{bookId} | Get a book by id for a specific author

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Assembly](docs/Assembly.md)
 - [Model.Author](docs/Author.md)
 - [Model.AuthorForUpdate](docs/AuthorForUpdate.md)
 - [Model.Book](docs/Book.md)
 - [Model.BookForCreation](docs/BookForCreation.md)
 - [Model.BookForCreationWithAmountOfPages](docs/BookForCreationWithAmountOfPages.md)
 - [Model.BookWithConcatenatedAuthorName](docs/BookWithConcatenatedAuthorName.md)
 - [Model.CallingConventions](docs/CallingConventions.md)
 - [Model.ConstructorInfo](docs/ConstructorInfo.md)
 - [Model.CustomAttributeData](docs/CustomAttributeData.md)
 - [Model.CustomAttributeNamedArgument](docs/CustomAttributeNamedArgument.md)
 - [Model.CustomAttributeTypedArgument](docs/CustomAttributeTypedArgument.md)
 - [Model.EventAttributes](docs/EventAttributes.md)
 - [Model.EventInfo](docs/EventInfo.md)
 - [Model.Exception](docs/Exception.md)
 - [Model.FieldAttributes](docs/FieldAttributes.md)
 - [Model.FieldInfo](docs/FieldInfo.md)
 - [Model.GenericParameterAttributes](docs/GenericParameterAttributes.md)
 - [Model.ICustomAttributeProvider](docs/ICustomAttributeProvider.md)
 - [Model.IntPtr](docs/IntPtr.md)
 - [Model.LayoutKind](docs/LayoutKind.md)
 - [Model.MemberInfo](docs/MemberInfo.md)
 - [Model.MemberTypes](docs/MemberTypes.md)
 - [Model.MethodAttributes](docs/MethodAttributes.md)
 - [Model.MethodBase](docs/MethodBase.md)
 - [Model.MethodImplAttributes](docs/MethodImplAttributes.md)
 - [Model.MethodInfo](docs/MethodInfo.md)
 - [Model.ModelError](docs/ModelError.md)
 - [Model.ModelStateEntry](docs/ModelStateEntry.md)
 - [Model.ModelValidationState](docs/ModelValidationState.md)
 - [Model.Module](docs/Module.md)
 - [Model.ModuleHandle](docs/ModuleHandle.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.OperationType](docs/OperationType.md)
 - [Model.ParameterAttributes](docs/ParameterAttributes.md)
 - [Model.ParameterInfo](docs/ParameterInfo.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.PropertyAttributes](docs/PropertyAttributes.md)
 - [Model.PropertyInfo](docs/PropertyInfo.md)
 - [Model.RuntimeFieldHandle](docs/RuntimeFieldHandle.md)
 - [Model.RuntimeMethodHandle](docs/RuntimeMethodHandle.md)
 - [Model.RuntimeTypeHandle](docs/RuntimeTypeHandle.md)
 - [Model.SecurityRuleSet](docs/SecurityRuleSet.md)
 - [Model.StructLayoutAttribute](docs/StructLayoutAttribute.md)
 - [Model.Type](docs/Type.md)
 - [Model.TypeAttributes](docs/TypeAttributes.md)
 - [Model.TypeInfo](docs/TypeInfo.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication

