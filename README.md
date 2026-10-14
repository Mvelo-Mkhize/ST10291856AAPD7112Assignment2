Municipal Services App

A Windows Forms application that lets residents:
- Report municipal service issues
- Browse, search, and receive recommendations for local events and announcements

HOW TO COMPILE AND RUN

1. Open the project folder and double-click MunicipalServicesApp.sln (or MunicipalServicesApp.csproj) to open it in Visual Studio.

2. If Visual Studio asks to restore NuGet packages, allow it. This project uses only the built-in .NET Framework libraries, so no extra packages are needed.

3. Press F5 on your keyboard, or click the green Start button at the top of Visual Studio, to build and run the application.

4. The Municipal Services Portal main menu will appear.

HOW TO USE

MAIN MENU
1. Report Issues
2. Local Events and Announcements
3. Service Request Status (placeholder message only)

REPORT ISSUES
1. Click Report Issues on the main menu.
2. Enter the Location of the problem.
3. Select a Category from the dropdown list.
4. Type a Description of the issue.
5. Optionally click Browse... to attach a photo or document.
6. The progress bar fills as you complete each field.
7. Click Submit. A reference number is shown and the form resets.
8. Click Back to Main Menu to return.

LOCAL EVENTS AND ANNOUNCEMENTS
1. Click Local Events and Announcements on the main menu.
2. The event list is empty on first run. Add events using the Add New Event panel at the bottom of the form:
      - Title
      - Category (type a new one or pick an existing one)
      - Priority (High, Medium, or Low)
      - Date
      - Location
      - Description
   Then click Add Event.
3. Use the Category dropdown and the Filter by date checkbox at the top to search for events.
4. Double-click any event in the list to view its full details. Events you open appear under Recently Viewed.
5. The Recommended for You panel updates after every search and suggests events based on the categories you search most, the priority of each event, and how soon the event takes place.
6. Click Back to Main Menu to return.
