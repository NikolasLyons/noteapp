import { createRouter, createWebHashHistory } from "vue-router"

/**
 * @param {string} page
 */
function loadPage(page) {
  console.log(page)
  return () => import(`./pages/${page}.vue`);
}
const routes = [
  {
    path: '/',
    name: 'Home',
    component: loadPage('HomePage')

  }
]

export const router = createRouter({
  linkActiveClass: "router-link-active",
  linkExactActiveClass: "router-link-exact-active",
  history: createWebHashHistory(),
  routes
})
