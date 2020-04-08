# MVP-Automation
1. Docker installed and running
2. cd to folder where you have downloaded docker-compose.yaml
3. run docker-compose up // to start and output will look like below

Starting mvp_mars.web.app_1          ... done
Starting mvp_mars.service.profile_1  ... done
Starting mvp_mars.service.identity_1 ... done
Starting mvp_mars.service.listing_1  ... done
Attaching to mvp_mars.service.identity_1, mvp_mars.service.listing_1, mvp_mars.web.app_1, mvp_mars.service.profile_1
mars.service.listing_1   | Hosting environment: docker
mars.service.listing_1   | Content root path: /dotnetapp
mars.service.listing_1   | Now listening on: http://[::]:51689
mars.web.app_1           | Hosting environment: docker
mars.web.app_1           | Content root path: /dotnetapp
mars.web.app_1           | Now listening on: http://[::]:5000
mars.service.profile_1   | Hosting environment: docker
mars.service.profile_1   | Content root path: /dotnetapp
mars.service.profile_1   | Now listening on: http://[::]:60190
mars.service.identity_1  | Hosting environment: docker
mars.service.identity_1  | Content root path: /dotnetapp
mars.service.identity_1  | Now listening on: http://[::]:60968

4. cd to thr project folder of MVP [MVP-Automation]
5. Open KMVPAutomation.sln
6. Build the project
7. goto test explorer
8. Run test one by one [not run all]
