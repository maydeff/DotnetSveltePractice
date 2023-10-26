<script>
    import Icon from '@iconify/svelte'
</script>

<div
    class="bg-dark-secondary w-full max-w-5xl p-6 rounded-lg shadow mx-auto my-3 text-left"
>
    <!-- Thread Header -->
    <div class="mb-4">
        <h1 class="text-xl font-semibold">Thread about very complex problem</h1>
        <p class="text-gray-500">Posted by @user123 • 2 hours ago</p>
    </div>

    <!-- Thread Content -->
    <div class="mb-4">
        <p class="text-lg">
            Aliquam luctus mi eu sapien lobortis consequat ac mattis lacus.
            Aliquam luctus justo odio, non convallis mi rutrum a. Ut condimentum
            dui sed arcu egestas, a tincidunt velit aliquet. Aenean sit amet
            porttitor erat, quis vestibulum arcu. Proin mi est, molestie ac quam
            ultricies, elementum molestie ex. Donec vestibulum mi lorem,
            porttitor ornare ante condimentum eget. Quisque eleifend, nisl sit
            amet hendrerit posuere, mi turpis vestibulum risus, ac tincidunt
            velit eros a dui. Aliquam egestas libero mattis, porttitor augue
            eget, finibus lectus. Nullam eget mollis massa. Ut nulla quam,
            aliquet pellentesque semper a, aliquam vel elit. Aliquam varius
            congue tincidunt. Nulla venenatis volutpat volutpat. In pulvinar
            elit urna, sed feugiat purus sodales non. Aliquam facilisis lacus
            sit amet pulvinar iaculis. Lorem ipsum dolor sit amet, consectetur
            adipiscing elit. Nam vitae fermentum ligula, vitae euismod lectus.
        </p>
    </div>

    <!-- Thread Actions -->
    <div class="flex items-center space-x-4 text-gray-500">
        <button class="flex items-center space-x-2">
            <Icon icon="mdi:arrow-up" color="green" />
            <span>123 Upvotes</span>
        </button>
        <button class="flex items-center space-x-2">
            <Icon icon="mdi:arrow-down" color="red" />
            <span>12 Downvotes</span>
        </button>
        <button class="flex items-center space-x-2">
            <Icon icon="mdi:comment-multiple" color="blue" />
            <span>35 Comments</span>
        </button>
    </div>
</div>
