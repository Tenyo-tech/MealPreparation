import { jsonRequest } from "../helpers/jsonRequest.js";

//let baseUrl = 'http://localhost:3030/data/games';
let baseUrl = 'http://localhost:3030/data/games';

async function getAll(){
    let result = await jsonRequest(baseUrl);
    return result;
}

async function get(id){
    let result = await jsonRequest(`${baseUrl}/${id}`);
    return result;
}

async function create(item){
    let result = await jsonRequest(`${baseUrl}`, 'Post', item, true);
    return result;
}

async function update(item, id){
    let result = await jsonRequest(`${baseUrl}/${id}`, 'Put', item, true);
    return result;
}

async function getAllGames(){
    let result = await jsonRequest(`${baseUrl}?sortBy=_createdOn%20desc`);
    return result;
}

async function getRecentGames(){
    let result = await jsonRequest(`${baseUrl}?sortBy=_createdOn%20desc&distinct=category`);
    return result;
}

async function getRecentMeals(){
    let result = await jsonRequest(`${baseUrl}?sortBy=_createdOn%20desc&distinct=category`);
    return result;
}


async function deleteItem(id){
    let result = await jsonRequest(`${baseUrl}/${id}`, 'Delete', undefined, true);
    return result;
}


export default {
    getAll,
    get,
    create,
    update,
    deleteItem,
    getAllGames,
    getRecentGames
}