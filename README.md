az-app-fd-vnet-bas-vm-sql-st \
az-arch-1

- dotnet CLI
- az CLI
- Github Actions
- Azure App Services
- Azure Application Insights
- Azure Frontdoor
- Azure Web Application Firewall Polyce
	
- Azure Virtual Network
- Azure Bastion
- Azure Virtual Machine
- Azure Storage Account

1. Create virtual network
2. Create subnets
3. Create app service plan
	https://docs.microsoft.com/en-us/cli/azure/appservice/plan?view=azure-cli-latest#az-appservice-plan-create
	
	az appservice plan create \
		-n plan-arch1-prod-eastus2-001 \
		-g rg-arch1-prod-001 \
		--sku B1
		
4. Create app insights
5. Create web app and assign app insihgs and vnet/snet
	https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest#az-webapp-create

3. Create bastion
4. Create admin vm


Create app
	git clone https://github.com/stefam/az-arch-1 \
	cd az-arch-1 \
	dotnet new webapp -o app --language "C#" --framework net5.0 \
	dotnet new sln \
	dotnet sln add ./app/app.csproj \
\
Important:
https://docs.microsoft.com/en-us/azure/frontdoor/private-link
https://samcogan.com/service-endpoints-and-private-link-whats-the-difference/