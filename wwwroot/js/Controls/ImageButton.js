class ImageButton extends ControlBase {
    constructor(owner, parent, name, src) {
        super(owner, parent);
        this.Name = name;
        this.ImageButtonLayer = document.createElement("div");
        this.ImageButtonLayer.setAttribute("id", this.Name);
        this.ImageSrc = src;
        this.Image = document.createElement("img");
    }

    AddToView() {
        this.Image.setAttribute("src", this.ImageSrc);
        this.Image.style.cssFloat = "left";
        this.Parent.appendChild(this.ImageButtonLayer);
        this.ImageButtonLayer.appendChild(this.Image);
    }
}