<script>
    import Icon from '@iconify/svelte'
</script>

<header class="text-read-white">
    <nav
        class="grid grid-cols-12 bg-dark-primary text-white h-20 w-full fixed top-0 left-0 items-center justify-center z-40"
    >
        <div class="col-span-2 p-2 text-center">
            <a href="#">
                <h1 class="text-3xl italic">WEBSITE</h1>
            </a>
        </div>
        <div class="col-span-4">
            <div class="bg-gray-900 text-white p-4 pl-8">
                <div class="max-w-md relative">
                    <input
                        type="text"
                        class="w-full h-10 pl-12 pr-4 text-read-white bg-dark-search-bar border border-border-primary rounded-full focus:outline-none shadow-sm shadow-border-shadow"
                        placeholder="Search anything..."
                    />
                    <div
                        class="absolute top-0 left-0 flex items-center h-10 pl-4"
                    >
                        <Icon icon="mdi:database-search-outline" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-span-6">
            <div class="flex justify-end items-center p-4">
                <div class="mx-2">
                    <Icon
                        icon="mdi:information-variant-circle-outline"
                        width={30}
                    />
                </div>
                <div class="mx-2">
                    <Icon icon="mdi:bell-alert-outline" width={30} />
                </div>
                <div class="mx-2">
                    <Icon icon="mdi:cog" width={30} />
                </div>
                <div class="mx-2">
                    <img
                        class="w-10 h-10 rounded-full mr-4"
                        src="https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80"
                        alt="Avatar 1"
                    />
                </div>
            </div>
        </div>
    </nav>
</header>
