Eu utilizei o PostMan para teste

GET


Retorna lista de Clientes

http://localhost:63534/api/clients

Retorna cliente em específico

http://localhost:63534/api/clients/1

POST

http://localhost:63534/api/clients

Ex:
{
	"RazaoSocial":"Teste",
	"CNPJ":"13.783.273/0001-00"	
}

PUT

http://localhost:63534/api/clients

Ex:
{
	"Codigo": 1
	"RazaoSocial":"Teste",
	"CNPJ":"13.783.273/0001-00"	
}

DELETE

http://localhost:63534/api/clients/1


