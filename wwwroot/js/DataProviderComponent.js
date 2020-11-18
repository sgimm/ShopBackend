class DataProviderComponent extends TComponent {
    constructor(owner, parent, valkyra) {
        super(owner, parent, valkyra);
        this.RestProvider;
        this.LastMessage;
    }
    Initialize() {

    }
    SendMessage(msg) {
        switch (msg.MessageType) {
            case "RegisterAccount":
                this.RestProvider = new RestHelper("http://localhost:59867/api/Customers/Registration", "Post");
                this.LastMessage = msg;                 
                this.RestProvider.Request(JSON.stringify(msg.MsgContent), this.RequestCompleted.bind(this));
                alert("Try to Register");
                break;
            case "Login":
                this.RestProvider = new RestHelper("http://localhost:59867/api/Customers/Login", "POST");
                this.RestProvider.Request(JSON.stringify(msg.MsgContent), this.LoginComplete.bind(this));
                break;
            case "ProductViewControlSliderDataLoad":
                var items = [];
                items.push('images/nhh1.png');
                items.push('images/nhh2.png');
                items.push('images/nhh3.png');
                items.push('images/nhh4.png');
                msg.MessageType = msg.CallBack;
                msg.MessageContent = items;
                this.Owner.SendMessage(msg);
                break;
        }
    }

    RequestCompleted(result) {
        if (this.LastMessage.CallBack) {
            var msg = new TMessageObject();
            msg.MessageType = this.LastMessage.CallBack;
            msg.MsgContent = result;
            this.Owner.SendMessage(msg);            
        }
    }

    RegisterComplete(result) {

    }
    
    LoginComplete(result) {
        var msg = new TMessageObject();
        if (!result.token) {
            msg.MessageType = "OnLoginError";
        }
        else {
            msg.MessageType = "OnLoginSuccess";
        }
        msg.MsgContent = result;
        this.Owner.SendMessage(msg);
    }
}