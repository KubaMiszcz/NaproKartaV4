# NaproKartaV4 - *[link to working app here](http://naprokarta.kubamiszcz.hostingasp.pl/user/chart/2?chartid=1)*

test login: `asd@asd.asd`
pass: `asd`

NaproKarta - Webservice for fulfilling sheets from Naprotechnology (attaching photos, notes, card and description printing, Android client) - C#, .NET, MVC, Angular2+, REST API
* logowanie EFIdentity
* dolaczanie zdjeci i notatek
* frontend: Angular5, MaterialsUI, bootstrap 4
* backend: WebApi, MVC, EntityFramework, Dependency Injection, CodeFirst
* baza danych: MSSQL 


##In future Version:
* make it PWA


==TODO:
sprawdzanie czy to twoj chart
erro page albo jakismesage jak error
naprawic to zeby dziallao tez z authorize przy naglowku options

==PM> 
Enable-Migrations -force -verbose
Add-Migration 1
Update-Database -Verbose -ProjectName NaproKarta.Server -StartUpProjectName NaproKarta.Server 

==
%windir%\Microsoft.NET\Framework\v4.0.30319\aspnet_regiis.exe -i
in my case C:\windows\Microsoft.NET\Framework\v4.0.30319\aspnet_regiis.exe -i

==npm
npm i -g npm

==`git` discard all local changes/commits and pull from upstream

git reset --hard origin/master
git pull origin master

git reset --hard origin/[your master branch name]
git pull origin [your master branch name]
