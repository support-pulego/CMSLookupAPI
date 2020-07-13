# CMSLookupAPI

## Managed Care Organisation
- Get Accredited Medical  Care Organisations list
 `api/managedcareorganisations`
- Get  MCO Service by MCO ID
  `api/managedcareorganisations/mcoservice/{id}`
- Get MCO conditions by mco id and comply period
  `api/managedcareorganisations/{ifkmcoid}/{complyperiod}`
  
## Accredited medical scheme administrators
- GET Accredited medical scheme administrators list
`api/accrediatedmedschemeadministrators`
- GET Accredited medical scheme conditions
`api/accrediatedmedschemeadministrators/{ifkAdminID}`

## Auditors
- GET Auditors
`api/auditor`

## Audit firms
- GET Auditfirm list
`api/auditfirm`
- GET Auiditfirm by ID
 `api/auditfirm/{id}`
 - GET Auditfirm Conditions by auditfirm ID
 `api/auditfirm/conditions/{id}`
 ## IFRS Advisors
 - GET IFRS Advisors list
 `api/ifrsadvisors`
 - GET IFRS Advisors by id 
 `api/ifrsadvisors/{id}`
 ## Medical Schemes
 - GET All medical Schemes
 `api/medschemes` OR `api/medschemes?filterBy=A`
 - GET medical schemes by ID
 `api/medschemes/{id}`
 
 ## SP Complaints
- Create complaint
`api/sp-web-complaint`
- Complaint against categories
`api/sp-web-complaint/against-categories`
- Complaint By categories
`api/sp-web-complaint/by-categories`
- SP province
`api/sp-web-complaint/sp-province`
- SP Scheme benefit options
`api/sp-web-complaint/sp-scheme-benefit-options/{entityid}`
- SP Title
`api/sp-web-complaint/sp-title`
- Entity List by Category
`api/sp-web-complaint/entity-list-by-category/{entitytypeid}`

# Deployment steps
## Steps to follow when deploying to IIS after running the build and publishing web successful.

- Step no.1: Run build solutions and Publish Web. Then click publish.
- Step no.2: Then click target directory, the file explorer will open, then select all files excluding appsetting.json file. 
- Step no.3: Then create zip file, therefore copy the zip file to the server where IIS is installed.
- Step no.4 Then paste it in Downloads then open the zip file, Therefore copy all the files to IIS WWWRoot folder.
- Step no.5 Then paste the zip content there, therefore after that stop and start the web app in IIS.

Done with your deployments now you should be able to view the web via the server domain name.
