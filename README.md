# ReproducingFileUploadIssue
Site to reproduce issue with submitting large data in a POST

# Steps to reproduce:
- Run the site by running `dotnet run` on the command line
- Navigate to https://localhost:5003
- Click the button to select a file - choose the "large-file.jpg" from the root of this repo to make it fail
- Wait until the file has uploaded (you will see a preview)
- Click the Submit button
