# Digging through the rabbit hole

reversed code for a trojan ransomware installer found on a freelancer site

## How the virus works

The virus is disguised inside a windows shortcut (.lnk) that exploit a security bug on powershell 
(so it works only on windows vista und up ) that allow a base64encoded string 
to be executed as a powershellscript with administrative privileges
the execution can be started by the victim by launching the shortcut or exploting other security breaches in browser or other 
infection vector that allow automate opening of archives (see in the wild ).

Practicaly the victim  will download and execute a powershell script base64encoded in the body of .lnk file.
In order to ensure that, the .lnk file it present to the user an icon similar to a folder. As the default system configuration is to treat 
.lnk   as special files (it is likely not to see that the file is a shortcut 
and it is unlikely that a normal user will  know that a shortcut can be harmfull) ,
almost all users can be convinced to click on the shortcut. There are some little variations but at the end, 
the powershell code will be launched.
At the time of writting, only Avira and Sophos have detected online that in fact the archive content contain dangerous data
https://www.virustotal.com/en/file/2ca830b7d91d2e9593b17951e4591ecf70a66d08f8173a95a7e0e26ead4910b2/analysis/
For reference, Kaspersky free antivirus did not detect localy archive as potentialy dangerous

The role of the powershell is to access http://honcho.biz/fl/_ _ _ dll.exe (underscore added in order to protect current readers).
At the time of writting (11.03.2016), the file is still available on the site, even if the freelancer.com , the original source of infection
was warned about the problem and blacklisted the user who uploaded malitious code.(Ticket ID: PXV-565-13198
Status: In Progress on 9 March, problem reported on 3 March)

This link is recognised by antivirus (at least Kaspersky) as being potentialy dangerous, but the user can download and execute dll.exe. Also,
the file is not recognised as a virus so it.

An investigator will find that executable file is a .net application. The role of the application is to extract and launch some trojan code
burned inside. The decompiler show this code as base64 encoded string encrypted (the main virus  ) with Encoding.Utf8.GetBytes("AzWJrYnj") as keycode.




