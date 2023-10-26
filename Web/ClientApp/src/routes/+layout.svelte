<script>
    import EventFeed from '../EventFeed.svelte'
    import SideBar from '../SideBar.svelte'
    import TopBar from '../TopBar.svelte'
</script>

<div>
    <div class="block">
        <TopBar />

        <div class="grid grid-cols-12">
            <aside
                class="col-span-2 sticky bg-dark-primary text-white top-0 left-0 z-10 pt-20 h-screen transition-transform"
            >
                <SideBar />
            </aside>
            <main class="col-span-8 bg-dark-primary p-4 mt-16">
                <slot />
            </main>
            <div class="bg-dark-primary text-read-white col-span-2 mt-16">
                <EventFeed />
            </div>
        </div>
    </div>
</div>

<style>
</style>
