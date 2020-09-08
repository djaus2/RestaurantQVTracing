# RestaurantQRCode

Because of COVID-19 there is a need to all attendances per table at a Resaurant.  
Can generate a unique code for each table. 
When user actions the QR Code, the table is automatically included in the log.
This is a QR Code based Blazor WebAssembly app. 

## Details

- Data is sent to SQL
- All pages show on sidebar.
  - But for deployment need to hide some, eg behind authentication.
  - Want users to accept before getting to log page
  - Admin login (Mangement) should be similarly hidden.
  - Magic numbers are in the path for these pages which is checked.
    - A daily pin number is also used for some pages.
 - FetchData page
   - Only in admin mode
   - Now has Calendar
- Pseudo Admin mode.
  - Login from Management tab
    - Add /Management/137 to base Url to access
    - Also QRCode page: Add /qrcode to base URl
  - App then enables the QR Code page and FetchData page.
  - Logout on FetchData page.
  - Login and out may need the page to be refreshed.
  - Also; Once Admined in if go to non Admin page you are logged out.
- Next add a database, probably SQLite.

## Need
- [Telerik UI for Blazor](https://www.telerik.com/blazor-ui)
- [NodalTimePicket](https://www.nuget.org/packages/NodaTimePicker/) Will remove this.
