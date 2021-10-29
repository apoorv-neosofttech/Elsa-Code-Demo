# Elsa-Code-Demo
Steps to run and test workflows
1. Run as Elsa.Server instead of IIS Express
2. Run following command in powershell:

	For SMTP: docker run -p 3000:80 -p 2525:25 rnwood/smtp4dev:linux-amd64-3.1.0-ci0856
  
3. Open following links in the browser other than http://localhost:5001
  
	For SMTP: http://localhost:3000/
 
4. Run following API in Postman:
  
  Method: Post
  
  URL: https://localhost:5001/v1/documents
  
  Body(raw->json): 
  ```json
  {
    "Id": "3",
    "Author": {
        "Name": "John",
        "Email": "john@gmail.com"
    },
    "Body": "This is sample document."
}
```

References: 

https://elsa-workflows.github.io/elsa-core/docs/guides/guides-document-approval

https://elsa-workflows.github.io/elsa-core/docs/extensibility/extensibility-custom-activities
