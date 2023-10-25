<script>
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
            <main class="col-span-8 p-8 mt-16 border border-solid border-b-8">
                <slot />
            </main>
            <div class="bg-dark-secondary text-white col-span-2 p-4 mt-16">
                Event Feed
            </div>
        </div>
    </div>
</div>

<style>
</style>
