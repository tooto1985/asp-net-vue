var Foo = Vue.component("foo-component", {
    template: "#foo-component"
});
var Bar = Vue.component("bar-component", {
    template: "#bar-component"
});
var Zoo = Vue.component("zoo-component", {
    template: "#zoo-component"
});

var routes = [
    { path: '/foo', component: Foo },
    { path: '/bar', component: Bar },
    { path: '/zoo', component: Zoo }
];

var router = new VueRouter({
    mode: "history",
    routes: routes
});


Vue.component("header-component", {
    template: "#header-component"
});


new Vue({
    router: router,
    data: {
        message: "Hello World"
    }
}).$mount('#app');




