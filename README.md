# NaproKartaV4



==TOFDO:
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