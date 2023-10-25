<script>
    import SideBar from '../SideBar.svelte'
    import TopBar from '../TopBar.svelte'
</script>

<div class="flex">
    <div class="block">
        <TopBar />

        <div class="flex">
            <SideBar />
            <main class="mt-20 p-2 bg-green-400">
                <slot />
            </main>
        </div>
    </div>
</div>

<style>
</style>
