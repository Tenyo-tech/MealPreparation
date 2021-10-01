import { html } from "./../../node_modules/lit-html/lit-html.js";

export let navTemplate = (nav) => html `
<a href="/all-meals">All Meals</a>
${nav.isLoggedIn
? loggedControls(nav)
: guestControlls()}
`;


let loggedControls = (nav) => html `
<div id="user">
    <a href="/create">Create Meal</a>
    <a href="javascript:void(0)" @click=${nav.logoutHadnler}>Logout</a>
</div>`;

let guestControlls = () => html `
<div id="guest">
    <a href="/login">Login</a>
    <a href="/register">Register</a>
</div>`;


