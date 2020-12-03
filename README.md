# CMSLookupAPI

## Managed Care Organisation
- Get Accredited Medical  Care Organisations list
 `/managedcareorganisations`
- Get  MCO Service by MCO ID
  `/managedcareorganisations/mcoservice/{id}`
- Get MCO conditions by mco id and comply period
  `/managedcareorganisations/{ifkmcoid}/{complyperiod}`
  
## Accredited medical scheme administrators
- GET Accredited medical scheme administrators list
`/accrediatedmedschemeadministrators`
- GET Accredited medical scheme conditions
`/accrediatedmedschemeadministrators/{ifkAdminID}`

## Auditors
- GET Auditors
`/auditor`

## Audit firms
- GET Auditfirm list
`/auditfirm`
- GET Auiditfirm by ID
 `/auditfirm/{id}`
 - GET Auditfirm Conditions by auditfirm ID
 `/auditfirm/conditions/{id}`
 ## IFRS Advisors
 - GET IFRS Advisors list
 `/ifrsadvisors`
 - GET IFRS Advisors by id 
 `/ifrsadvisors/{id}`
 ## Medical Schemes
 - GET All medical Schemes
 `/medschemes` OR `api/medschemes?filterBy=A`
 - GET medical schemes by ID
 `/medschemes/{id}`
 
 ## SP Complaints
- Create complaint
`/sp-web-complaint`
- Complaint against categories
`/sp-web-complaint/against-categories`
- Complaint By categories
`/sp-web-complaint/by-categories`
- SP province
`/sp-web-complaint/sp-province`
- SP Scheme benefit options
`/sp-web-complaint/sp-scheme-benefit-options/{entityid}`
- SP Title
`/sp-web-complaint/sp-title`
- Entity List by Category
`/sp-web-complaint/entity-list-by-category/{entitytypeid}`

# Deployment steps
## Steps to follow when deploying to IIS after running the build and publishing web successful.

- Step no.1: Run build solutions and Publish Web. Then click publish.
- Step no.2: Then click target directory, the file explorer will open, then select all files excluding appsetting.json file. 
- Step no.3: Then create zip file, therefore copy the zip file to the server where IIS is installed.
- Step no.4 Then paste it in Downloads then open the zip file, Therefore copy all the files to IIS WWWRoot folder.
- Step no.5 Then paste the zip content there, therefore after that stop and start the web app in IIS.

Done with your deployments now you should be able to view the web via the server domain name.
