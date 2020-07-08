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
`api/accrediatedmedschemeadministators/{ifkAdminID}`

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
`api/sp-web-complaint/by-cotegories`
- SP province
`api/sp-web-complaint/sp-province`
- SP Scheme benefit options
`api/sp-web-complaint/sp-scheme-benefit-options/{entityid}`
- SP Title
`api/sp-web-complaint/sp-title`
- Entity List by Category
`api/sp-web-complaint/entity-list-by-category/{entitytypeid}`
