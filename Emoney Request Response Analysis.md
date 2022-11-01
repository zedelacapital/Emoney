![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.001.png)







Emoney Integration

Provider Requests and Responses

[**GetInfo**](#_Toc116912060)**

[**GetTransactionInfo**](#_Toc116912061)

[**Pay**](#_Toc116912062)



















|**Credentials** |
| - |
|**Secret**|5PSSDCRF5GWMB2PULJ3H|
|**Hash Generation Function for Postman**|<p>Getinfo:</p><p>var message **=** request **+** serviceID **+** Distributor **+** secret</p><p>var sha256Hash **=**  CryptoJS.SHA256(message).**toString**()</p><p>pm.environment.**set**("sha256Hash",sha256Hash)</p><p></p><p>GetTransactionId:</p><p>var message **=** request **+** transactionCode **+** Distributor **+** secret</p><p>var sha256Hash **=**  CryptoJS.SHA256(message).**toString**()</p><p>pm.environment.**set**("sha256Hash",sha256Hash)</p><p></p><p>Pay:</p><p>var message **=** request **+** service **+** amount **+** currency **+** transaction **+** Distributor **+** secret</p><p>var sha256Hash **=**  CryptoJS.SHA256(message).**toString**()</p><p>pm.environment.**set**("sha256Hash",sha256Hash)</p><p></p>|

















# **GetInfo**


|**Request**|
| :-: |
|**Http Method**|Post|
|**URL**|https://api.emoney.ge/distributors/Service.svc?wsdl|


|**Header**|
| :-: |
|**SOAPAction**|http://tempuri.org/IService/GetInfo|
|**Content-Type**|text/xml; charset=utf-8|


|**Body**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Distributor|TESTER|Distributor|
|sha256Hash|N/A|Generated based on: **request + service + Distributor + secret**|
|service|1||
|account|360806773|User ID|
|description|“No matter”|Optional Parameter|











|**Body XML Example**|
| :- |
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/" xmlns:emon="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Common" xmlns:emon1="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`   `<soapenv:Header/>

`   `<soapenv:Body>

`      `<tem:GetInfo>

`         `<tem:request>

`            `<emon:Distributor>{{Distributor}}</emon:Distributor>

`            `<emon:Hash>{{sha256Hash}}</emon:Hash>

`            `<emon:Parameters>

`               `<emon1:Parameter>

`                  `<emon1:Key>service</emon1:Key>

`                  `<emon1:Value>{{service}}</emon1:Value>

`               `</emon1:Parameter>

`               `<emon1:Parameter>

`                  `<emon1:Key>account</emon1:Key>

`                  `<emon1:Value>{{account}}</emon1:Value>

`               `</emon1:Parameter>

`               `<emon1:Parameter>

`                  `<emon1:Key>description</emon1:Key>

`                  `<emon1:Value>{{description}}</emon1:Value>

`               `</emon1:Parameter>               

`            `</emon:Parameters>

`         `</tem:request>

`      `</tem:GetInfo>

`   `</soapenv:Body>

</soapenv:Envelope>
![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.002.png)


|**Response**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Code|1|Success OK|
|ExtraInfo||Error Codes, If any.|
|ID|224B497B5F4B4155A5D7D67E314C2EEF||
|Message|Success||
|SystemCode|OK|Optional Parameter|
|Balance|||
|MinimalPayAmount|0.01||
|AdditionalInfo|ს. ქ.||
|Commission|0.00||




|**Response XML Example**|
| :- |
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">

`    `<s:Body>

`        `<GetInfoResponse xmlns="http://tempuri.org/">

`            `<GetInfoResult xmlns:a="http://schemas.datacontract.org/2004/07/LB.Shared" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">

`                `<a:Code>1</a:Code>

`                `<a:ExtraInfo i:nil="true"/>

`                `<a:ID>224B497B5F4B4155A5D7D67E314C2EEF</a:ID>

`                `<a:Message>Success</a:Message>

`                `<a:SystemCode>OK</a:SystemCode>

`                `<a:Value xmlns:b="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`                    `<b:Parameter>

`                        `<b:Key>Balance</b:Key>

`                        `<b:Value/>

`                    `</b:Parameter>

`                    `<b:Parameter>

`                        `<b:Key>MinimalPayAmount</b:Key>

`                        `<b:Value>0.01</b:Value>

`                    `</b:Parameter>

`                    `<b:Parameter>

`                        `<b:Key>AdditionalInfo</b:Key>

`                        `<b:Value>ს. ქ.</b:Value>

`                    `</b:Parameter>

`                    `<b:Parameter>

`                        `<b:Key>Commission</b:Key>

`                        `<b:Value>0.00</b:Value>

`                    `</b:Parameter>

`                `</a:Value>

`            `</GetInfoResult>

`        `</GetInfoResponse>

`    `</s:Body>

</s:Envelope>


![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.003.png)








# **GetTransactionInfo** 


|**Request**|
| :-: |
|**Http Method**|Post|
|**URL**|https://api.emoney.ge/distributors/Service.svc?wsdl|


|**Header**|
| :-: |
|**SOAPAction**|http://tempuri.org/IService/GetTransactionInfo|
|**Content-Type**|text/xml; charset=utf-8|


|**Body**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Distributor|TESTER|Distributor|
|sha256Hash|N/A|Generated based on: **request + transaction + Distributor + secret**|
|transaction|1487458041|Transaction Code|


|**Body XML Example**|
| :- |
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/" xmlns:emon="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Common" xmlns:emon1="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`   `<soapenv:Header/>

`   `<soapenv:Body>

`      `<tem:GetTransactionInfo>

`         `<tem:request>

`            `<emon:Distributor>{{Distributor}}</emon:Distributor>

`            `<emon:Hash>{{sha256Hash}}</emon:Hash>

`            `<emon:Parameters>

`               `<emon1:Parameter>

`                  `<emon1:Key>transaction</emon1:Key>

`                  `<emon1:Value>{{transactionCode}}</emon1:Value>

`               `</emon1:Parameter>

`            `</emon:Parameters>

`         `</tem:request>

`      `</tem:GetTransactionInfo>

`   `</soapenv:Body>

</soapenv:Envelope>

![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.004.png)



|**Response**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Code|1|Success OK|
|ExtraInfo|True|Error Codes, If any.|
|ID|224B497B5F4B4155A5D7D67E314C2EEF|ID|
|Message|Success|Message from the provider system|
|SystemCode|OK|Optional Parameter|
|Amount|1|Available balance|
|Code|1487458041|Minimal payment amount|
|Currency|GEL|Initials|
|Description|Test transaction|Description of the Transaction|
|ID|78745804|Commission|
|IP|213.131.41.182|IP|
|ReceiverIdentities|True||
|Status|Canceled|Transaction Status|
|Type|Test transaction|Transaction Type|












|**Response XML Example**|
| :- |
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">

`    `<s:Body>

`        `<GetTransactionInfoResponse xmlns="http://tempuri.org/">

`            `<GetTransactionInfoResult xmlns:a="http://schemas.datacontract.org/2004/07/LB.Shared" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">

`                `<a:Code>1</a:Code>

`                `<a:ExtraInfo i:nil="true"/>

`                `<a:ID>54732BCE612946D9A25CF59B03608D7A</a:ID>

`                `<a:Message>Success</a:Message>

`                `<a:SystemCode>OK</a:SystemCode>

`                `<a:Value xmlns:b="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`                    `<b:Amount>1</b:Amount>

`                    `<b:Code>1487458041</b:Code>

`                    `<b:Currency>GEL</b:Currency>

`                    `<b:Description>Test transaction</b:Description>

`                    `<b:ID>78745804</b:ID>

`                    `<b:IP>213.131.41.182</b:IP>

`                    `<b:ReceiverIdentities i:nil="true"/>

`                    `<b:Status>Canceled</b:Status>

`                    `<b:Type>Test transaction</b:Type>

`                `</a:Value>

`            `</GetTransactionInfoResult>

`        `</GetTransactionInfoResponse>

`    `</s:Body>

</s:Envelope>
![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.005.png)













# **Pay**


|**Request**|
| :-: |
|**Http Method**|Post|
|**URL**|https://api.emoney.ge/distributors/Service.svc?wsdl|


|**Header**|
| :-: |
|**SOAPAction**|http://tempuri.org/IService/Pay|
|**Content-Type**|text/xml; charset=utf-8|


|**Body**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Distributor|TESTER|Distributor|
|sha256Hash|N/A|<p>Hash is Generated based on:</p><p></p><p>**request + service + amount + currency + transaction + Distributor + secret**</p>|
|amount|1|Amount|
|currency|GEL|Currency Code|
|service|1|Service ID, Provider Side.|
|transaction|5454|transaction ID from persistence database |
|account|360806773|eMoney account ID|







|**Body XML Example**|
| :- |
`  `<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/" xmlns:emon="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Common" xmlns:emon1="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`   `<soapenv:Header/>

`   `<soapenv:Body>

`      `<tem:Pay>

`         `<tem:request>

`            `<emon:Distributor>{{Distributor}}</emon:Distributor>

`            `<emon:Hash>{{sha256Hash}}</emon:Hash>

`            `<emon:Parameters>

`               `<emon1:Parameter>

`                  `<emon1:Key>amount</emon1:Key>

`                  `<emon1:Value>{{amount}}</emon1:Value>

`               `</emon1:Parameter>

`                `<emon1:Parameter>

`                  `<emon1:Key>currency</emon1:Key>

`                  `<emon1:Value>{{currency}}</emon1:Value>

`               `</emon1:Parameter>

`                `<emon1:Parameter>

`                  `<emon1:Key>service</emon1:Key>

`                  `<emon1:Value>{{service}}</emon1:Value>

`               `</emon1:Parameter>

`                `<emon1:Parameter>

`                  `<emon1:Key>transaction</emon1:Key>

`                  `<emon1:Value>{{transaction}}</emon1:Value>

`               `</emon1:Parameter>

`                  `<emon1:Parameter>

`                  `<emon1:Key>account</emon1:Key>

`                  `<emon1:Value>{{customerCode}}</emon1:Value>

`               `</emon1:Parameter>

`            `</emon:Parameters>

`         `</tem:request>

`      `</tem:Pay>

`   `</soapenv:Body>

</soapenv:Envelope>

![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.006.png)


|**Response**|
| :-: |
|**Parameter**|**Example**|**Description**|
|Code|1|Success OK|
|ExtraInfo|True|Error Codes, If any.|
|ID|224B497B5F4B4155A5D7D67E314C2EEF|ID|
|Message|Success|Message from the provider system|
|SystemCode|OK|Optional Parameter|
|Amount|1|Available balance|
|Code|1487458041|Minimal payment amount|
|Currency|GEL|Initials|
|Description|Test transaction||
|ID|78745804|Commission|
|IP|213.131.41.182|IP|
|ReceiverIdentities|True||
|Status|Canceled|Transaction Status|
|Type|Test transaction|Transaction Type|


|**Response XML Example**|
| :- |
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">

`    `<s:Body>

`        `<PayResponse xmlns="http://tempuri.org/">

`            `<PayResult xmlns:a="http://schemas.datacontract.org/2004/07/LB.Shared" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">

`                `<a:Code>1</a:Code>

`                `<a:ExtraInfo i:nil="true"/>

`                `<a:ID>6463784E17C344DB9C03F52ACF35B0E7</a:ID>

`                `<a:Message>Success</a:Message>

`                `<a:SystemCode>OK</a:SystemCode>

`                `<a:Value xmlns:b="http://schemas.datacontract.org/2004/07/EmoneyDistributorService.Model">

`                    `<b:Amount>1</b:Amount>

`                    `<b:Code>1487458041</b:Code>

`                    `<b:Currency>GEL</b:Currency>

`                    `<b:Description>Test transaction</b:Description>

`                    `<b:ID>78745804</b:ID>

`                    `<b:IP>213.131.41.182</b:IP>

`                    `<b:ReceiverIdentities i:nil="true"/>

`                    `<b:Status>Canceled</b:Status>

`                    `<b:Type>Test transaction</b:Type>

`                `</a:Value>

`            `</PayResult>

`        `</PayResponse>

`    `</s:Body>

</s:Envelope>

![](Aspose.Words.0c7cba0a-da69-45f4-a8e6-de887b0b3ab4.007.png)



