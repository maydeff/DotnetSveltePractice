<script>
    import Icon from '@iconify/svelte'
</script>

<header class="text-read-white">
    <nav
        class="grid grid-cols-12 bg-dark-primary text-white h-20 w-full fixed top-0 left-0 items-center justify-center z-40"
    >
        <div class="col-span-2 p-2">
            <p>Website Name</p>
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
            <p>Other Stuff</p>
        </div>
    </nav>
</header>
