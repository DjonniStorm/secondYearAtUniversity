import stylesString from './card.module.scss?inline';
import style from './card.module.scss';
// import icon from "../../public/images/icons/add.svg";

export class Card extends HTMLElement {
  static get observedAttributes() {
    return ['img', 'name', 'link', 'icon'];
  }
  #link;
  #name;
  /* захардкоженная иконка на кнопке */
  #icon;
  /* обложка */
  #img;

  constructor() {
    super();
    this.#icon = '/images/icons/add.svg';
  }

  render() {
    console.log(this.#icon);

    return `
    <style>
      ${stylesString}
    </style>
    
    <div class="${style.card}">
            <div class="${style.card__cover}">
                <img class="${style.card__cover__img}" src="${
                  this.#img
                }" alt="${this.#name} cover" lazy />
            </div>
            <div class="${style.card__description}">
                <span class="${style.card__description__text}">
                    ${this.#name}
                </span>
                <button class="${style.card__button}">
                <a href="${this.#link}">
                  <img src="${this.#icon}" class="${style.card__button__img} 
                    alt="add icon" />
                </a>
                </button>
            </div>
          </div>
      `;
  }

  attributeChangedCallback(name, oldValue, newValue) {
    if (name === 'img') {
      this.#img = newValue;
    } else if (name === 'href') {
      this.#link = newValue;
    } else if (name === 'name') {
      this.#name = newValue;
    } else if (name === 'icon') {
      if (newValue) {
        this.#icon = newValue;
      }
    }
  }

  updateData() {
    this.#img = this.getAttribute('img');
    this.#link = this.getAttribute('link');
    this.#name = this.getAttribute('name');
    // this.#icon = this.getAttribute("icon");
  }

  connectedCallback() {
    this.attachShadow({ mode: 'open' });
    this.updateData();
    this.shadowRoot.innerHTML = this.render();
  }
}
