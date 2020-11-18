class CustomerDataProviderComponent extends TComponent {
    constructor(owner, parent, valkyra) {
        super(owner, parent, valkyra);
        this.RestProvider;
        this.LastMessage;
    }

    SendMessage(msg) {
        switch (msg.MessageType) {
            case "CustomerDataLoad":
                this.RestProvider = new RestHelper("http://localhost:59867/api/Customers/" + msg.MsgContent.customerId, "GET");
                this.LastMessage = msg;
                this.RestProvider.Request(null, this.CustomerDataLoaded.bind(this));                
                break;
            case "CustomerUpdate":
                this.RestProvider = new RestHelper("http://localhost:59867/api/Customers/" + msg.MsgContent.id, "PUT");
                this.RestProvider.Request(JSON.stringify(msg.MsgContent), this.CustomerDataSaved);
                break;
        }
    }

    CustomerDataLoaded(result) {
        this.LastMessage.MsgContent = result;
        this.LastMessage.MessageType = this.LastMessage.CallBack;
        this.Owner.SendMessage(this.LastMessage);
    }

    CustomerDataSaved(result) {      
    }
}